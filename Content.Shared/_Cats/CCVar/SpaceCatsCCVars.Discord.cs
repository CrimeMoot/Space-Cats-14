using Robust.Shared.Configuration;

namespace Content.Shared._Cats.CCVar;
public sealed partial class SpaceCatsCCVars
{
        
    /// <summary>
    /// Discord Webhooks
    /// </summary>
    
    public static readonly CVarDef<string> DiscordBanWebhook =
        CVarDef.Create("discord.ban_webhook", string.Empty, CVar.SERVERONLY);
}