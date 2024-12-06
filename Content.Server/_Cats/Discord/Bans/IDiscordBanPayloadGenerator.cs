using Content.Server.Discord;
using Content.Server.Discord.Webhooks;

namespace Content.Server.Cats.Discord.Bans;

public interface IDiscordBanPayloadGenerator
{
    WebhookPayload Generate(BanInfo info);
}
