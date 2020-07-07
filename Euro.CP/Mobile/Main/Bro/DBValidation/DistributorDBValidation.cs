// <copyright file="DistributorDBValidation.cs" company="IDT">
// Copyright (c) IDT. All rights reserved.
// </copyright>
namespace Euro.Viracor.Labalert.Main.Bro.DBValidation
{
    using System.Data;
    using Euro.Core.Automation.Utilities.DB;
   

    /// <summary>
    /// This class is incharge to save querys for Distributors.
    /// </summary>
    public class DistributorDBValidation
    {
        /// <summary>
        /// Gets distributor data form distributor table
        /// </summary>
        /// <param name="userName">distributor userName</param>
        /// <returns>distributor_id, distributor_finance_id, user_name, email, IS_TEST_ACCOUNT from db as datatable</returns>
        public static DataTable GetDistributorEnitityData(string userName)
        {
            return DBConnection.GetData("OneApp", string.Format(Querys.DistributorEntityInfo, userName));
        }
    }
}
