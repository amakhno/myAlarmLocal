namespace fLocalAlarm
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.hLabel = new System.Windows.Forms.Label();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.enemyAlarm = new System.Windows.Forms.CheckBox();
            this.neutAlarm = new System.Windows.Forms.CheckBox();
            this.xBox = new System.Windows.Forms.NumericUpDown();
            this.yBox = new System.Windows.Forms.NumericUpDown();
            this.hBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WarpX = new System.Windows.Forms.NumericUpDown();
            this.WarpY = new System.Windows.Forms.NumericUpDown();
            this.IsWarpCheckbox = new System.Windows.Forms.CheckBox();
            this.IsBackgroundCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.xBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarpX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarpY)).BeginInit();
            this.SuspendLayout();
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(13, 13);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(90, 13);
            this.xLabel.TabIndex = 0;
            this.xLabel.Text = "Screen X position";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(13, 53);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(90, 13);
            this.yLabel.TabIndex = 1;
            this.yLabel.Text = "Screen Y position";
            // 
            // hLabel
            // 
            this.hLabel.AutoSize = true;
            this.hLabel.Location = new System.Drawing.Point(13, 93);
            this.hLabel.Name = "hLabel";
            this.hLabel.Size = new System.Drawing.Size(110, 13);
            this.hLabel.TabIndex = 4;
            this.hLabel.Text = "Local height in names";
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.confirmButton.Location = new System.Drawing.Point(12, 227);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(194, 227);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // enemyAlarm
            // 
            this.enemyAlarm.AutoSize = true;
            this.enemyAlarm.Location = new System.Drawing.Point(16, 176);
            this.enemyAlarm.Name = "enemyAlarm";
            this.enemyAlarm.Size = new System.Drawing.Size(86, 17);
            this.enemyAlarm.TabIndex = 8;
            this.enemyAlarm.Text = "Enemy alarm";
            this.enemyAlarm.UseVisualStyleBackColor = true;
            // 
            // neutAlarm
            // 
            this.neutAlarm.AutoSize = true;
            this.neutAlarm.Location = new System.Drawing.Point(16, 199);
            this.neutAlarm.Name = "neutAlarm";
            this.neutAlarm.Size = new System.Drawing.Size(88, 17);
            this.neutAlarm.TabIndex = 9;
            this.neutAlarm.Text = "Neutral alarm";
            this.neutAlarm.UseVisualStyleBackColor = true;
            // 
            // xBox
            // 
            this.xBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.xBox.InterceptArrowKeys = false;
            this.xBox.Location = new System.Drawing.Point(12, 30);
            this.xBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(160, 20);
            this.xBox.TabIndex = 10;
            // 
            // yBox
            // 
            this.yBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.yBox.InterceptArrowKeys = false;
            this.yBox.Location = new System.Drawing.Point(12, 70);
            this.yBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(160, 20);
            this.yBox.TabIndex = 11;
            // 
            // hBox
            // 
            this.hBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hBox.InterceptArrowKeys = false;
            this.hBox.Location = new System.Drawing.Point(12, 111);
            this.hBox.Name = "hBox";
            this.hBox.Size = new System.Drawing.Size(160, 20);
            this.hBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pilot Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 150);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(160, 20);
            this.nameTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Image = global::fLocalAlarm.Properties.Resources.Delete_Icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(110, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Telegram";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Отварп X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Отварп Y";
            // 
            // WarpX
            // 
            this.WarpX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.WarpX.InterceptArrowKeys = false;
            this.WarpX.Location = new System.Drawing.Point(178, 30);
            this.WarpX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.WarpX.Name = "WarpX";
            this.WarpX.Size = new System.Drawing.Size(94, 20);
            this.WarpX.TabIndex = 10;
            // 
            // WarpY
            // 
            this.WarpY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.WarpY.InterceptArrowKeys = false;
            this.WarpY.Location = new System.Drawing.Point(178, 70);
            this.WarpY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.WarpY.Name = "WarpY";
            this.WarpY.Size = new System.Drawing.Size(94, 20);
            this.WarpY.TabIndex = 11;
            // 
            // IsWarpCheckbox
            // 
            this.IsWarpCheckbox.AutoSize = true;
            this.IsWarpCheckbox.Location = new System.Drawing.Point(182, 96);
            this.IsWarpCheckbox.Name = "IsWarpCheckbox";
            this.IsWarpCheckbox.Size = new System.Drawing.Size(62, 17);
            this.IsWarpCheckbox.TabIndex = 16;
            this.IsWarpCheckbox.Text = "Разгон";
            this.IsWarpCheckbox.UseVisualStyleBackColor = true;
            // 
            // IsBackgroundCheckbox
            // 
            this.IsBackgroundCheckbox.AutoSize = true;
            this.IsBackgroundCheckbox.Location = new System.Drawing.Point(182, 119);
            this.IsBackgroundCheckbox.Name = "IsBackgroundCheckbox";
            this.IsBackgroundCheckbox.Size = new System.Drawing.Size(90, 17);
            this.IsBackgroundCheckbox.TabIndex = 17;
            this.IsBackgroundCheckbox.Text = "Задний план";
            this.IsBackgroundCheckbox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 262);
            this.ControlBox = false;
            this.Controls.Add(this.IsBackgroundCheckbox);
            this.Controls.Add(this.IsWarpCheckbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hBox);
            this.Controls.Add(this.WarpY);
            this.Controls.Add(this.yBox);
            this.Controls.Add(this.WarpX);
            this.Controls.Add(this.xBox);
            this.Controls.Add(this.neutAlarm);
            this.Controls.Add(this.enemyAlarm);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.xBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarpX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarpY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label hLabel;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.CheckBox enemyAlarm;
        private System.Windows.Forms.CheckBox neutAlarm;
        private System.Windows.Forms.NumericUpDown xBox;
        private System.Windows.Forms.NumericUpDown yBox;
        private System.Windows.Forms.NumericUpDown hBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown WarpX;
        private System.Windows.Forms.NumericUpDown WarpY;
        private System.Windows.Forms.CheckBox IsWarpCheckbox;
        private System.Windows.Forms.CheckBox IsBackgroundCheckbox;
    }
}