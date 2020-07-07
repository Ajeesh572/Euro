// <copyright file="ResetFilterButtonEnum.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Enums.Products
{
    using Euro.Core.Automation.Utilities.Helpers.Enums;

    /// <summary>
    /// This enum handles scope of the entity <see cref="ResetFilterButtonEnum"/>.
    /// </summary>
    public enum ResetFilterButtonEnum
    {
        [XpathParameter("IsAllowedForCustomers")]
        AllowedForCustomers,

        [XpathParameter("Status")]
        Status,

        [XpathParameter("IsAllowedForRetailers")]
        AllowedForRetailers,

        [XpathParameter("IsAllowedForDistributors")]
        AllowedForDistributors,

        [XpathParameter("IsFeeBased")]
        CommissionType,
    }
}
