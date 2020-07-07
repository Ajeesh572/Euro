// <copyright file="TableActionButtonsEnum.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Enums.Products
{
    using Euro.Core.Automation.Utilities.Helpers.Enums;

    /// <summary>
    /// Enum represents the Actions Buttons
    /// </summary>
    public enum TableActionButtonsEnum
    {
        [LocatorName("BtnEditSelectedRow")]
        EditSelectedRow,

        [LocatorName("BtnEditProductMetaData")]
        EditMetaData,

        [LocatorName("BtnDeactivateProduct")]
        DeactivateProduct,

        [LocatorName("BtnUploadBlackList")]
        UploadBlackList,

        [LocatorName("BtnDownloadBlackList")]
        DownloadBlackList,

        [LocatorName("BtnActivateProduct")]
        ActivateProduct,

        [LocatorName("BtnSubmit")]
        Submit,

        [LocatorName("BtnCancel")]
        Cancel,

        [LocatorName("BtnDeleteProduct")]
        DeleteProduct
    }
}
