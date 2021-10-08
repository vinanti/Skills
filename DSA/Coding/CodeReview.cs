using System;
using System.Collections.Generic;

namespace Coding
{
    public class ServiceLayer
    {
        private DbLayer dbLayer;
        public ServiceLayer()
        {
            dbLayer = new DbLayer();
        }

        public List<int> GetEmpIds(string companyName)
        {
            // check companyname is not null or empty. 
            return dbLayer.FindEmployeeIdByCompanyName(companyName);
        }
    }
    public class DbLayer
    {
        private Common common;
        public DbLayer()
        {
            // DO something
            var connString = common.GetConnectionString();
        }

        public List<int> FindEmployeeIdByCompanyName(string companyName)
        {
            // some logic is there.
            return new List<int>();
        }
    }
    public class Common
    {
        public string GetConnectionString()
        {
            // read string from config file.
            return "connection string";
        }
    }
}
	


