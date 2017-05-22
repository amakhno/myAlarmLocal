using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taikandi.Telebot;
using Taikandi.Telebot.Types;
using TeleSharp.TL;
using TeleSharp.TL.Messages;
using TLSharp.Core;

namespace fLocalAlarm
{
    public class TelegramMessager
    {

        public TelegramMessager(string apiKey)
        {
            _telebot = new Telebot(apiKey);
        }

        public void InsertNewApi(string apiKey)
        {
            _telebot = new Telebot(apiKey);
        }

        //____________________
        private Telebot _telebot;
        private List<long> chatsId = new List<long>();


        public bool IsStop = false;
        public async Task RunAsync()
        {
            // Used for getting only the unconfirmed updates.
            // It is recommended to stored this value between sessions. 
            // More information at https://core.telegram.org/bots/api#getting-updates
            var offset = 0L;

            while (!IsStop)
            {
                // Use this method to receive incoming updates using long polling.
                // Or use Telebot.SetWebhook() method to specify a URL to receive incoming updates.
                List<Update> updates = (await this._telebot.GetUpdatesAsync(offset).ConfigureAwait(false)).ToList();
                if (updates.Any())
                {
                    offset = updates.Max(u => u.Id) + 1;

                    foreach (Update update in updates)
                    {
                        switch (update.Type)
                        {
                            case UpdateType.Message:
                                await this.CheckMessagesAsync(update.Message).ConfigureAwait(false);
                                break;
                            case UpdateType.InlineQuery:
                                await this.CheckInlineQueryAsync(update).ConfigureAwait(false);
                                break;
                            case UpdateType.ChosenInlineResult:
                                this.CheckChosenInlineResult(update);
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    }
                }

                await Task.Delay(TimeSpan.FromSeconds(1)).ConfigureAwait(false);
            }
        }

        private async Task CheckMessagesAsync(Taikandi.Telebot.Types.Message message)
        {
            // Assume we are doing more than echoing stuff.
            if (message == null)
                return;

            await this._telebot.SendChatActionAsync(message.Chat.Id, ChatAction.Typing).ConfigureAwait(false);
            await Task.Delay(TimeSpan.FromSeconds(0.5)).ConfigureAwait(false);

            if (message.Text.ToUpper() == "/START")
            {
                if (chatsId.Contains(message.Chat.Id))
                {
                    await this._telebot.SendMessageAsync(message.Chat.Id, "Already stated").ConfigureAwait(false);
                    return;
                }
                chatsId.Add(message.Chat.Id);
                await this._telebot.SendMessageAsync(message.Chat.Id, "Start successfully").ConfigureAwait(false);
                return;
            }

            if (message.Text.ToUpper() == "/STOP")
            {
                if (chatsId.Contains(message.Chat.Id))
                {
                    chatsId.Remove(message.Chat.Id);
                    await this._telebot.SendMessageAsync(message.Chat.Id, "Stopped successfully").ConfigureAwait(false);
                }
                else
                {
                    await this._telebot.SendMessageAsync(message.Chat.Id, "Already stoped").ConfigureAwait(false);
                }                
                return;
            }

            if (message.Text.ToUpper() == "/STATUS")
            {
                if (chatsId.Contains(message.Chat.Id))
                {
                    await this._telebot.SendMessageAsync(message.Chat.Id, "You are subscribed").ConfigureAwait(false);
                }
                else
                {
                    await this._telebot.SendMessageAsync(message.Chat.Id, "You are not subscribed").ConfigureAwait(false);
                }

                if (Tracker.tracker.isRunning())
                {
                    await this._telebot.SendMessageAsync(message.Chat.Id, Tracker.tracker.StatusForTelegram).ConfigureAwait(false); ;
                }
                else
                {
                    await this._telebot.SendMessageAsync(message.Chat.Id, "Monitor is stopped").ConfigureAwait(false);
                }
                return;
            }

            // This method will send a text message (obviously).
            await this._telebot.SendMessageAsync(message.Chat.Id, "???").ConfigureAwait(false);
        }

        public async Task SendToAll(string text)
        {
            foreach (long a in chatsId)
            {
                await this._telebot.SendMessageAsync(a, text).ConfigureAwait(false);
            }
        }

        private async Task CheckInlineQueryAsync(Update update)
        {
            // Telebot will support all 19 types of InlineQueryResult.
            // To see available inline query results:
            // https://core.telegram.org/bots/api#answerinlinequery
            var articleResult = new InlineQueryResultArticle
            {
                Id = Guid.NewGuid().ToString("N"),
                Title = "This is a title",
                Url = "https://core.telegram.org/bots/api#inlinequeryresultarticle"
            };

            var photoResult = new InlineQueryResultPhoto
            {
                Id = Guid.NewGuid().ToString("N"),
                Url = "https://telegram.org/file/811140636/1/hzUbyxse42w/4cd52d0464b44e1e5b",
                ThumbnailUrl = "https://telegram.org/file/811140636/1/hzUbyxse42w/4cd52d0464b44e1e5b"
            };


            var gifResult = new InlineQueryResultGif
            {
                Id = Guid.NewGuid().ToString("N"),
                Url = "http://i.giphy.com/ya4eevXU490Iw.gif",
                ThumbnailUrl = "http://i.giphy.com/ya4eevXU490Iw.gif"
            };

            var results = new InlineQueryResult[] { articleResult, photoResult, gifResult };
            await this._telebot.AnswerInlineQueryAsync(update.InlineQuery.Id, results).ConfigureAwait(false);
        }

        private void CheckChosenInlineResult(Update update)
        {
            Console.WriteLine("Received ChosenInlineResult.");
        }

    }
}
