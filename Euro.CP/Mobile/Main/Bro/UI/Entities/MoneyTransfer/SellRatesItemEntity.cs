// <copyright file="SellRatesItemEntity.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Entities.MoneyTransfer
{
    /// <summary>
    /// This class represents a sell rates with its attributes.
    /// </summary>
    public class SellRatesItemEntity
    {
        /// <summary>
        /// Gets or sets the Payer data.
        /// </summary>
        public string Payer { get; set; }

        /// <summary>
        /// Gets or sets the Delivery Method data.
        /// </summary>
        public string DeliveryMethod { get; set; }

        /// <summary>
        /// Gets or sets the From Amount data.
        /// </summary>
        public string FromAmount { get; set; }

        /// <summary>
        /// Gets or sets the To Amount data.
        /// </summary>
        public string ToAmount { get; set; }

        /// <summary>
        /// Gets or sets the Sell Rate data.
        /// </summary>
        public string SellRate { get; set; }
    }
}
