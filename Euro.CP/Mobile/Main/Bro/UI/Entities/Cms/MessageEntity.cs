// <copyright file="MessageEntity.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Entities.Cms
{
    /// <summary>
    /// This class contains the attributes for Message.
    /// </summary>
    public class MessageEntity
    {
        /// <summary>
        /// Gets or sets the Subject data.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the Body data.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the Message Type data.
        /// </summary>
        public string CardHolderName { get; set; }

        /// <summary>
        /// Gets or sets the Is Popup data.
        /// </summary>
        public string IsPopup { get; set; }

        /// <summary>
        /// Gets or sets the Is Important data.
        /// </summary>
        public string IsImportant { get; set; }

        /// <summary>
        /// Gets or sets the All Distributors data.
        /// </summary>
        public string AllDistributors { get; set; }
    }
}
