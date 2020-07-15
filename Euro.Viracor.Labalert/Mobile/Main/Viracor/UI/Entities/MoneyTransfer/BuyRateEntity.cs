// <copyright file="BuyRateEntity.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Entities.MoneyTransfer
{
    /// <summary>
    /// This class represents a buy rate with its attributes.
    /// </summary>
    public class BuyRateEntity
    {
        /// <summary>
        /// Gets or sets of Payer Name.
        /// </summary>
        public string PayerName { get; set; }

        /// <summary>
        /// Gets or sets of Country Code.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or sets of Currency Code.
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets of Buy Rate.
        /// </summary>
        public string BuyRate { get; set; }
    }
}
