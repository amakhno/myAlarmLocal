using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fLocalAlarm
{
    public class ScreenCapturer
    {
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(string _ClassName, string _WindowName);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public static Image BackgroundScreen(string PilotName)
        {
            IntPtr handle = FindWindow(null, String.Format("EVE - {0}", PilotName));
            // get te hDC of the target window
            IntPtr hdcSrc = User.GetWindowDC(handle);
            // get the size
            User.RECT windowRect = new User.RECT();
            User.GetWindowRect(handle, ref windowRect);
            int width = windowRect.right - windowRect.left;
            int height = windowRect.bottom - windowRect.top;
            if (handle == (IntPtr)0)
            {
                throw new Exception("Окно пилота не найдено");
            }
            if ((width < 200) || (height < 200))
            {
                throw new Exception("Окно свернуто");
            }            
            // create a device context we can copy to
            IntPtr hdcDest = GDI.CreateCompatibleDC(hdcSrc);
            // create a bitmap we can copy it to,
            // using GetDeviceCaps to get the width/height
            IntPtr hBitmap = GDI.CreateCompatibleBitmap(hdcSrc, width, height);
            // select the bitmap object
            IntPtr hOld = GDI.SelectObject(hdcDest, hBitmap);
            // bitblt over
            GDI.BitBlt(hdcDest, 0, 0, width, height, hdcSrc, 0, 0, GDI.SRCCOPY);
            // restore selection
            GDI.SelectObject(hdcDest, hOld);
            User.ReleaseDC(handle, hdcSrc);
            // get a .NET image object for it
            Image img = Image.FromHbitmap(hBitmap);
            // free up the Bitmap object
            GDI.DeleteObject(hBitmap);
            GDI.DeleteObject(hdcDest);
            GDI.DeleteObject(hOld);
            GDI.DeleteObject(hdcSrc);
            GDI.DeleteObject(handle);
            return img;
        }

        public static Bitmap NonBackScreen()
        {
            Bitmap bmpScreenCapture = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                            Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(bmpScreenCapture))
            {
                g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                 Screen.PrimaryScreen.Bounds.Y,
                                 0, 0,
                                 bmpScreenCapture.Size,
                                 CopyPixelOperation.SourceCopy);
                
            }
            return bmpScreenCapture;
        }

        public static Bitmap getScreen(int x, int y, int width, int height, bool IsBackground = true)
        {
            Bitmap source;
            Image output;

            if (IsBackground)
            {
                output = ScreenCapturer.BackgroundScreen(Properties.Settings.Default.pilotName);
                source = new Bitmap(output);
            }
            else
            {
                source = NonBackScreen();
            }
            
            System.Drawing.Imaging.PixelFormat format =
                    source.PixelFormat;
            Rectangle cloneRect = new Rectangle(x, y, width, height);
            Bitmap bmpScreenCapture = source.Clone(cloneRect, format);
            source.Dispose();
            return bmpScreenCapture;
        }
    }

    public class GDI
    {

        public const int SRCCOPY = 0x00CC0020; // BitBlt dwRop parameter
        [DllImport("gdi32.dll")]
        public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest,
            int nWidth, int nHeight, IntPtr hObjectSource,
            int nXSrc, int nYSrc, int dwRop);
        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth,
            int nHeight);
        [DllImport("gdi32.dll")]
        public static extern IntPtr CreateCompatibleDC(IntPtr hDC);
        [DllImport("gdi32.dll")]
        public static extern bool DeleteDC(IntPtr hDC);
        [DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);
        [DllImport("gdi32.dll")]
        public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
    }
    /// <summary>
    /// Helper class containing User32 API functions
    /// </summary>
    public class User
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }
        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);
    }
}
