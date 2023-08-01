using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalIMS.Views.Admin
{
    public partial class DepartmentLists : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowDepartment();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
        }
        public void ShowDepartment()
        {
            String Query = "Select * from DepartmentTbl";
            DepartmentGV.DataSource = Con.GetDatas(Query);
            DepartmentGV.DataBind();
        }

        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.ShowDepartment();
            DepartmentGV.PageIndex = e.NewPageIndex;
            DepartmentGV.DataBind();
        }

        
    }
}