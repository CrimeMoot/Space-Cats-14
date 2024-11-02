using Robust.Shared.GameStates;

namespace Content.Shared.Backmen.Surgery.Tools;

[RegisterComponent, NetworkedComponent]
public sealed partial class HemostatComponent : Component, ISurgeryToolComponent
{
    public string ToolName => "a hemostat";
    public bool? Used { get; set; } = null;
}