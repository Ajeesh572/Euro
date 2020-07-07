// <copyright file="PricingGroupItemComponent.cs" company="Eurofins">
// Copyright (c) Eurofins. All rights reserved.
// </copyright>

namespace Euro.Viracor.Labalert.Main.Bro.UI.Components.MoneyTransfer
{
    using System;
    using System.Collections.Generic;
    using Euro.Core.Automation.Page.Base;
    using Euro.Core.Automation.Selenium;
    using Euro.Core.Automation.Utilities.CommonAction;
    using Euro.Viracor.Labalert.Main.Bro.UI.Enums.MoneyTransfer;
    using OpenQA.Selenium;

    public class PricingGroupItemComponent : BasePage
    {
        private const string AddPricingGroupItemsLocators = "AddPricingGroupItemsLocators";

        [IDTFindBy(File = AddPricingGroupItemsLocators, Locator = "DdlPaymentMethod")]
        private IWebElement ddlPaymentMethod;

        [IDTFindBy(File = AddPricingGroupItemsLocators, Locator = "DdlPayer")]
        private IWebElement ddlPayer;

        [IDTFindBy(File = AddPricingGroupItemsLocators, Locator = "DdlDeliveryMethod")]
        private IWebElement ddlDeliveryMethod;

        [IDTFindBy(File = AddPricingGroupItemsLocators, Locator = "TxtFromAmount")]
        private IWebElement txtFromAmount;

        [IDTFindBy(File = AddPricingGroupItemsLocators, Locator = "TxtToAmount")]
        private IWebElement txtToAmount;

        [IDTFindBy(File = AddPricingGroupItemsLocators, Locator = "DlCustomerFeeType")]
        private IWebElement dlCustomerFeeType;

        [IDTFindBy(File = AddPricingGroupItemsLocators, Locator = "TxtCustomerFee")]
        private IWebElement txtCustomerFee;

        [IDTFindBy(File = AddPricingGroupItemsLocators, Locator = "DlCommissionType")]
        private IWebElement dlCommissionType;

        [IDTFindBy(File = AddPricingGroupItemsLocators, Locator = "TxtCommission")]
        private IWebElement txtCommission;

        public PricingGroupItemComponent() { }

        /// <summary>
        /// Fills payment method field.
        /// </summary>
        /// <param name="paymentMethod">Payment Method</param>
        /// <returns>An instance of<see cref="PricingGroupItemComponent"/>.</returns>
        internal PricingGroupItemComponent FillPaymentMethod(string paymentMethod)
        {
            ddlPaymentMethod.SelectComboBox(paymentMethod);
            return this;
        }

        /// <summary>
        /// Fills payer field.
        /// </summary>
        /// <param name="payer">Payer</param>
        /// <returns>An instance of<see cref="PricingGroupItemComponent"/>.</returns>
        internal PricingGroupItemComponent FillPayer(string payer)
        {
            ddlPayer.SelectComboBox(payer);
            return this;
        }

        /// <summary>
        /// Fills delivery method field.
        /// </summary>
        /// <param name="deliveryMethod">delivery method</param>
        /// <returns>An instance of<see cref="PricingGroupItemComponent"/>.</returns>
        internal PricingGroupItemComponent FillDeliveryMethod(string deliveryMethod)
        {
            ddlDeliveryMethod.SelectComboBox(deliveryMethod);
            return this;
        }

        /// <summary>
        /// Fills from amount field.
        /// </summary>
        /// <param name="fromAmount">from amount</param>
        /// <returns>An instance of<see cref="PricingGroupItemComponent"/>.</returns>
        internal PricingGroupItemComponent FillFromAmount(string fromAmount)
        {
            CommonActions.SendKeys(txtFromAmount, fromAmount);
            return this;
        }

        /// <summary>
        /// Fills to amount field.
        /// </summary>
        /// <param name="toAmount">to amount</param>
        /// <returns>An instance of<see cref="PricingGroupItemComponent"/>.</returns>
        internal PricingGroupItemComponent FillToAmount(string toAmount)
        {
            CommonActions.SendKeys(txtToAmount, toAmount);
            return this;
        }

        /// <summary>
        /// Fills customer fee type field.
        /// </summary>
        /// <param name="customerFeeType">customer fee type</param>
        /// <returns>An instance of<see cref="PricingGroupItemComponent"/>.</returns>
        internal PricingGroupItemComponent FillCustomerFeeType(string customerFeeType)
        {
            dlCustomerFeeType.SelectComboBox(customerFeeType);
            return this;
        }

        /// <summary>
        /// Fills customer fee field.
        /// </summary>
        /// <param name="customerFee">customer fee</param>
        /// <returns>An instance of<see cref="PricingGroupItemComponent"/>.</returns>
        internal PricingGroupItemComponent FillCustomerFee(string customerFee)
        {
            CommonActions.SendKeys(txtCustomerFee, customerFee);
            return this;
        }

        /// <summary>
        /// Fills commission type field.
        /// </summary>
        /// <param name="commissionType">commission type</param>
        /// <returns>An instance of<see cref="PricingGroupItemComponent"/>.</returns>
        internal PricingGroupItemComponent FillCommissionType(string commissionType)
        {
            dlCommissionType.SelectComboBox(commissionType);
            return this;
        }

        /// <summary>
        /// Fills commission field.
        /// </summary>
        /// <param name="commission">commission</param>
        /// <returns>An instance of<see cref="PricingGroupItemComponent"/>.</returns>
        internal PricingGroupItemComponent FillCommission(string commission)
        {
            CommonActions.SendKeys(txtCommission, commission);
            return this;
        }

        /// <summary>
        /// Fills pricing group item modal.
        /// </summary>
        /// <param name="dictionary">The <see cref="Dictionary"/> to fill in the form.</param>
        internal void FillPricingGroupItemFrom(Dictionary<PricingGrougItemEnum, string> dictionary)
        {
            new List<PricingGrougItemEnum>(dictionary.Keys).ForEach(key => GetStrategyStepMap(dictionary)[key].Invoke());
        }

        /// <summary>
        /// Obtains the map with the functions to fill the <see cref="SenderForm"/>.
        /// </summary>
        /// <param name="dictionary"><see cref="Dictionary{StartEnum, String}"</param>
        /// <returns><seealso cref="Dictionary<StartEnum, Func<SenderForm>>"/></returns>
        private Dictionary<PricingGrougItemEnum, Func<PricingGroupItemComponent>> GetStrategyStepMap(Dictionary<PricingGrougItemEnum, string> dictionary)
        {
            Dictionary<PricingGrougItemEnum, Func<PricingGroupItemComponent>> strategyMap = new Dictionary<PricingGrougItemEnum, Func<PricingGroupItemComponent>>();
            strategyMap.Add(PricingGrougItemEnum.PaymentMethod, () => FillPaymentMethod(dictionary[PricingGrougItemEnum.PaymentMethod]));
            strategyMap.Add(PricingGrougItemEnum.Payer, () => FillPayer(dictionary[PricingGrougItemEnum.Payer]));
            strategyMap.Add(PricingGrougItemEnum.DeliveryMethod, () => FillDeliveryMethod(dictionary[PricingGrougItemEnum.DeliveryMethod]));
            strategyMap.Add(PricingGrougItemEnum.FromAmount, () => FillFromAmount(dictionary[PricingGrougItemEnum.FromAmount]));
            strategyMap.Add(PricingGrougItemEnum.ToAmount, () => FillToAmount(dictionary[PricingGrougItemEnum.ToAmount]));
            strategyMap.Add(PricingGrougItemEnum.CustomerFeeType, () => FillCustomerFeeType(dictionary[PricingGrougItemEnum.CustomerFeeType]));
            strategyMap.Add(PricingGrougItemEnum.CustomerFee, () => FillCustomerFee(dictionary[PricingGrougItemEnum.CustomerFee]));
            strategyMap.Add(PricingGrougItemEnum.CommissionType, () => FillCommissionType(dictionary[PricingGrougItemEnum.CommissionType]));
            strategyMap.Add(PricingGrougItemEnum.Commission, () => FillCommission(dictionary[PricingGrougItemEnum.Commission]));
            return strategyMap;
        }
    }
}
