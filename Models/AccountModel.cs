using Models.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    //lớp thao tác với bảng account
    public class AccountModel
    {
        private webapplicationdb context = null;
        public AccountModel()
        {
            context = new webapplicationdb();
        }
        public Account Login(string userName, string Password)
        {
            return context.Database.SqlQuery<Account>(
                "SELECT * FROM Account WHERE Username=@u AND pass=@p",
                 new SqlParameter("@u", userName),
                new SqlParameter("@p", Password)
                ).SingleOrDefault();
            /*string SQL = "SELECT * FROM Account WHERE ID='" +ID+ "' AND Username='"+userName+"' AND pass='"+password+"'";
            return context.Database.SqlQuery<int>(SQL).SingleOrDefault();*/
        }
    }
}
