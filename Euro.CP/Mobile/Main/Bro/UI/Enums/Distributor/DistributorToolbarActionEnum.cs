// <copyright file="DistributorToolbarActionEnum.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Enums.Distributor
{
    using Euro.Core.Automation.Utilities.Helpers.Enums;

    public enum DistributorToolbarActionEnum
    {
        [StringValue("Activate Distributor")]
        ActivateDistributor,

        [StringValue("Deactivate Distributor")]
        DeactivateDistributor,

        [StringValue("Open Portal")]
        OpenPortal,

        [StringValue("Go to Parent")]
        GoToParent
    }
}
