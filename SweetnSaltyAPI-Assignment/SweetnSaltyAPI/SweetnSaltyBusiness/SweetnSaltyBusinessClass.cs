using SweetnSaltyDbAccess;
using SweetnSaltyModels;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace SweetnSaltyBusiness
{
    public class SweetnSaltyBusinessClass : ISweetnSaltyBusinessClass
    {
        private readonly ISweetnSaltyDbAccessClass _dbAccess;
        public SweetnSaltyBusinessClass(ISweetnSaltyDbAccessClass Dbaccess)//you need a reference to the DbAccess Layer 
        {
            this._dbAccess = Dbaccess;
        }

        public Task<Flavor> PostFlavor(string flavor)
        {
            SqlDataReader dr = this._dbAccess.PostFlavor();
            if (dr.Read())
            {

            }
        }
    }
}
