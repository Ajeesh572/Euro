// <copyright file="MoneyTransferTransactionEntity.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>
namespace Euro.Viracor.Labalert.Main.Bro.UI.Entities.MoneyTransfer
{
    /// <summary>
    /// This class handles the money transfer transaction entity.
    /// </summary>
    public class MoneyTransferTransactionEntity
    {
        /// <summary>
        /// Gets or sets country of Money Transfer Transactions.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets status of Money Transfer Transactions.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets CpasId of Money Transfer Transactions.
        /// </summary>
        public string CpasId { get; set; }

        /// <summary>
        /// Gets or sets FromAmount of Money Transfer Transactions.
        /// </summary>
        public string FromAmount { get; set; }

        /// <summary>
        /// Gets or sets ToAmount of Money Transfer Transactions.
        /// </summary>
        public string ToAmount { get; set; }

        /// <summary>
        /// Gets or sets First Name of Money Transfer Transactions.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets Last Name of Money Transfer Transactions.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets MtId of Money Transfer Transactions.
        /// </summary>
        public string MtId { get; set; }

        /// <summary>
        /// Gets or sets DateRange of Money Transfer Transactions.
        /// </summary>
        public string DateRange { get; set; }

        /// <summary>
        /// Gets or sets Username of Money Transfer Transactions.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets FromDate of Money Transfer Transactions.
        /// </summary>
        public string FromDate { get; set; }

        /// <summary>
        /// Gets or sets ToDate of Money Transfer Transactions.
        /// </summary>
        public string ToDate { get; set; }

        /// <summary>
        /// Gets or sets Portal of Money Transfer Transactions.
        /// </summary>
        public string Portal { get; set; }

        /// <summary>
        /// Gets or sets Payment Method of Money Transfer Transactions.
        /// </summary>
        public string PaymentMethod { get; set; }
    }
}
