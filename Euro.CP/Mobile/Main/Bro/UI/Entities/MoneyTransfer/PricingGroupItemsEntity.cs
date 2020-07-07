// <copyright file="PricingGroupItemsEntity.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Entities.MoneyTransfer
{
    using System.Collections.Generic;

    /// <summary>
    /// This class handles the Pricing Group Items entity.
    /// </summary>
    public class PricingGroupItemsEntity
    {
        /// <summary>
        /// Gets or sets List of Payers.
        /// </summary>
        public List<string> PayersList { get; set; }

        /// <summary>
        /// Gets or sets the Country Currency data.
        /// </summary>
        public string CountryCurrency { get; set; }

        /// <summary>
        /// Gets or sets the Pricing Group data.
        /// </summary>
        public string PricingGroup { get; set; }

        /// <summary>
        /// Gets or sets the Currency Code data.
        /// </summary>
        public string Payers { get; set; }

        /// <summary>
        /// Gets or sets the Group Actions data.
        /// </summary>
        public string GroupActions { get; set; }

        /// <summary>
        /// Gets or sets value of Search text box.
        /// Gets or sets value of Search Country - Currency.
        /// </summary>
        public string SearchCountryCurrency { get; set; }

        /// <summary>
        /// Gets or sets value of Search Pricing Group.
        /// </summary>
        public string SearchPricingGroup { get; set; }

        /// <summary>
        /// Gets or sets value of a Dropdown List.
        /// </summary>
        public string DropdownListOption { get; set; }

        /// <summary>
        /// Gets or sets value of a Button.
        /// </summary>
        public string ButtonOption { get; set; }

        /// <summary>
        /// Gets or sets Country value.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets Currency value.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets Name field.
        /// </summary>
        public string Name { get; set; }
    }
}
