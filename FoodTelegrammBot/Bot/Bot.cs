using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;
using FoodTelegrammBot.Db;

namespace FoodTelegrammBot.Bot;

public class Bot
{
    private TelegramBotClient _botClient;
    
    private CancellationTokenSource _cancellationTokenSource; 

    public Bot()
    {
        _botClient = new TelegramBotClient("5314823245:AAEUOONE9IoXKaN_xvXfTKnSi3faaHCm9uY");
        _cancellationTokenSource = new CancellationTokenSource();
    }

    public void Start()
    {
        ReceiverOptions receiverOptions = new ReceiverOptions
        {
            AllowedUpdates = Array.Empty<UpdateType>()
        };

        _botClient.StartReceiving(
            BotHandlers.HandleUpdateAsync,
            BotHandlers.HandlePollingErrorAsync,
            receiverOptions,
            _cancellationTokenSource.Token
        );
    }

    public string GetBotName()
    {
        return _botClient.GetMeAsync().Result.Username;
    }
    
    public void Stop()
    {
        _cancellationTokenSource.Cancel();
        DbManager.GetInstance().CloseConnection();
    }
}