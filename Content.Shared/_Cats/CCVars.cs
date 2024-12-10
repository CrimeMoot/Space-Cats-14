using Robust.Shared.Configuration;
using Robust.Shared;

namespace Content.Shared._Cats.CCVars;

/// <summary>
///     Corvax modules console variables
/// </summary>
[CVarDefs]
// ReSharper disable once InconsistentNaming
public sealed class CCVars : CVars
{
        /*
        * AUTOVOTE SYSTEM
        */

        /// <summary>
        /// Enables the automatic voting system.
        /// <summary>
        public static readonly CVarDef<bool> AutoVoteEnabled =
            CVarDef.Create("vote.autovote_enabled", false, CVar.SERVERONLY);

        /// <summary>
        /// Automatically starts a map vote when returning to the lobby.
        /// Requires auto voting to be enabled.
        /// <summary>
        public static readonly CVarDef<bool> MapAutoVoteEnabled =
            CVarDef.Create("vote.map_autovote_enabled", false, CVar.SERVERONLY);

        /// <summary>
        /// Automatically starts a gamemode vote when returning to the lobby.
        /// Requires auto voting to be enabled.
        /// <summary>
        public static readonly CVarDef<bool> PresetAutoVoteEnabled =
            CVarDef.Create("vote.preset_autovote_enabled", false, CVar.SERVERONLY);

        #region Discord
        
        /// <summary>
        ///     The token used to authenticate with Discord. For the Bot to function set: discord.token, discord.guild_id, and discord.prefix.
        ///     If this is empty, the bot will not connect.
        /// </summary>
        public static readonly CVarDef<string> DiscordToken =
            CVarDef.Create("discord.token", string.Empty, CVar.SERVERONLY | CVar.CONFIDENTIAL);

        /// <summary>
        ///     The Discord guild ID to use for commands as well as for several other features, like the ahelp relay.
        ///     If this is empty, the bot will not connect.
        /// </summary>
        public static readonly CVarDef<string> DiscordGuildId =
            CVarDef.Create("discord.guild_id", string.Empty, CVar.SERVERONLY);

        /// <summary>
        ///     Prefix used for commands for the Discord bot.
        ///     If this is empty, the bot will not connect.
        /// </summary>
        public static readonly CVarDef<string> DiscordPrefix =
            CVarDef.Create("discord.prefix", "!", CVar.SERVERONLY);

        /// <summary>
        ///     The discord **FORUM** channel id that admin messages are sent to. If it's not a forum channel, everything will explode.
        /// </summary>
        public static readonly CVarDef<string> AdminAhelpRelayChannelId =
            CVarDef.Create("admin.ahelp_relay_channel_id", string.Empty, CVar.SERVERONLY);

        /// <summary>
        ///     If this is true, the ahelp relay shows that the response was from discord. If this is false, all messages an admin sends will be shown as if the admin was ingame.
        /// </summary>
        public static readonly CVarDef<bool> AdminAhelpRelayShowDiscord =
            CVarDef.Create("admin.ahelp_relay_show_discord", true, CVar.SERVERONLY);

        /// <summary>
        /// The discord channel id that OOC messages are sent to.
        /// </summary>
        public static readonly CVarDef<string> OocRelayChannelId =
            CVarDef.Create("ooc.relay_channel_id", "", CVar.SERVERONLY);
    #endregion
}