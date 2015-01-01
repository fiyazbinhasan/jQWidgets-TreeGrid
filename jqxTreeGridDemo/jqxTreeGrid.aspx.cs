using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using jqxTreeGridDemo.Models;
using Newtonsoft.Json;

namespace jqxTreeGridDemo
{
    public partial class jqxTreeGrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public static string GetData()
        {
            List<User> users = new List<User>
            {
                new User {Name = "Hakeem", Phone = "076 4876 6579", CurrentBalance = 6026, UserType = "Administrator", UserCode = "AD-00001"},
                new User {Name = "Lucian", Phone = "055 9658 5713", CurrentBalance = 9741, UserType = "Branch", UserCode = "BR-00001", ParentCode = "AD-00001"},
                new User {Name = "Felix",  Phone = "076 2291 6071", CurrentBalance = 8852, UserType = "Distributor", UserCode = "DR-00001", ParentCode = "BR-00001"},
                new User {Name = "Aquila", Phone = "056 5580 0460", CurrentBalance = 9095, UserType = "Agent", UserCode = "AG-00001", ParentCode = "DR-00001"},
                new User {Name = "Tyrone", Phone = "0916 103 0684", CurrentBalance = 5822, UserType = "User", UserCode = "UR-00001", ParentCode = "AG-00001"},

                new User {Name = "Jasper", Phone = "0916 103 0684", CurrentBalance = 9935 , UserType = "Branch", UserCode = "BR-00002", ParentCode = "AD-00001"},
                new User {Name = "Erasmus", Phone = "0314 951 0576", CurrentBalance = 5636 , UserType = "Distributor", UserCode = "DR-00002", ParentCode = "BR-00002"},
                new User {Name = "Elton", Phone = "0887 799 4296", CurrentBalance = 6448 , UserType = "Distributor", UserCode = "DR-00003", ParentCode = "BR-00002"},
                new User {Name = "Colt", Phone = "07624 841017", CurrentBalance = 5425, UserType = "Agent", UserCode = "AG-00002", ParentCode = "DR-00003"},
                new User {Name = "Phillip", Phone = "070 7469 2182", CurrentBalance = 8344, UserType = "User", UserCode = "UR-00002", ParentCode = "AG-00001"},
                new User {Name = "Lucian", Phone = "055 9658 5713", CurrentBalance = 9741, UserType = "User", UserCode = "UR-00003", ParentCode = "AG-00001"},
                new User {Name = "Aron", Phone = "0800 722148", CurrentBalance = 5527, UserType = "User", UserCode = "UR-00004", ParentCode = "AG-00002"},
            };

            string data = JsonConvert.SerializeObject(users);
            return data;
        }
    }
}