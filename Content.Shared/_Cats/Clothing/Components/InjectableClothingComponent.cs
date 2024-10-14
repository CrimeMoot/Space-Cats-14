using Content.Shared.Clothing.EntitySystems;
using Content.Shared.DoAfter;
using Content.Shared.Inventory;
using Robust.Shared.Audio;
using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Clothing.Components;

[RegisterComponent, Access(typeof(ClothingSystem), typeof(InventorySystem))]
public sealed partial class InjectionProtectionComponent : Component
{
    /// <summary>
    /// A field indicating the protection of clothing from any injection
    /// </summary>
    [DataField("injectionProtection")]
    public bool HasInjectionProtection = true;
}