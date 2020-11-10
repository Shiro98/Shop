using Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CategoryModel
    {
        private webapplicationdb context = null;
        public CategoryModel()
        {
            context = new webapplicationdb();
        }
        public List<Category> ListAll()
        {
            var list = context.Database.SqlQuery<List<Category>>("Sp_Category_ListAll").ToList();
            return list;
        }
    }
}
