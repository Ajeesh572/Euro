// <copyright file="Querys.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>
namespace Euro.Viracor.Labalert.Main.Bro.DBValidation
{
    /// <summary>
    /// This class is incharge to save querys for xgen.
    /// </summary>
    public class Querys
    {
        public const string DistributorEntityInfo = "Select distributor_id, distributor_finance_id, user_name, email, IS_TEST_ACCOUNT from ONEAPP.DISTRIBUTOR where user_name  = '{0}'";
        public const string GetInfoFromRetailerByPin = "select * from ONEAPP.MV_RETAILER where pin = '{0}'";
    }
}
