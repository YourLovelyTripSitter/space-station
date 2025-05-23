﻿using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;
using Robust.Client.UserInterface.XAML;
using Robust.Shared.Prototypes;

namespace Content.Client._Sunrise.BloodCult.UI.Altar;

[GenerateTypedNameReferences]
public partial class AltarListingControl : Control
{
    public AltarListingControl(EntityPrototype prototype,
        Robust.Client.Graphics.Texture icon,
        Action<string>? clickAction)
    {
        RobustXamlLoader.Load(this);

        ToolTip = $"{prototype.Name}\n{prototype.Description}";

        BuyListingButton.TextureNormal = icon;
        BuyListingButton.OnButtonDown += _ => clickAction?.Invoke(prototype.ID);
    }
}
