using System.Threading.Tasks;

namespace Content.Server.Cats.Discord.Bans;

public interface IDiscordBanInfoSender
{
    Task SendBanInfoAsync<TGenerator>(BanInfo info)
        where TGenerator : IDiscordBanPayloadGenerator, new();
}
