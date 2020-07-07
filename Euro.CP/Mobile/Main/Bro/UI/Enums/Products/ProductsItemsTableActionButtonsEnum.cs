// <copyright file="ProductsItemsTableActionButtonsEnum.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Enums.Products
{
    using Euro.Core.Automation.Utilities.Helpers.Enums;

    /// <summary>
    /// Enum represents the Actions Buttons
    /// </summary>
    public enum ProductsItemsTableActionButtonsEnum
    {
        [LocatorName("BtnProductItemMetadata")]
        EditMetaData,

        [LocatorName("BtnDeActivateProductItem")]
        DeactivateProductItem,

        [LocatorName("BtnDiscontinueSellingProductItem")]
        StopSellingProductItem,

        [LocatorName("BtnActivateProductItem")]
        ActivateProductItem,

        [LocatorName("BtnDeleteProductItem")]
        DeleteProductItem
    }
}
