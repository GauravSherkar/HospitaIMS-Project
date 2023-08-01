using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalIMS.Views.Admin
{
    public partial class DepartmentList : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
          Con=new Models.Functions();
          ShowDepartment();
        }
        public void ShowDepartment()
        {
            String Query = "Select * from DepartmentTbl";
            DepartmentGV.DataSource = Con.GetDatas(Query);
            DepartmentGV.DataBind();
        }
    }
}