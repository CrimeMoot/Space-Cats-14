using Content.Shared.Actions;
using Robust.Shared.GameStates;

namespace Content.Shared.Backmen.Overlays;

[RegisterComponent, NetworkedComponent]
public sealed partial class ThermalVisionComponent : SwitchableOverlayComponent
{
    public override string? ToggleAction { get; set; } = "ToggleThermalVision";

    public override Color Color { get; set; } = Color.FromHex("#F84742");
}

public sealed partial class ToggleThermalVisionEvent : InstantActionEvent;