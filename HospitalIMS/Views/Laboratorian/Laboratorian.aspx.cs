using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalIMS.Views.Laboratorian
{
    public partial class Laboratorian : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con= new Models.Functions();
            ShowLaboratorian();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        public void ShowLaboratorian()
        {
            string Query = "Select * from LaboratorianTbl";
            LaboratorianGV.DataSource = Con.GetDatas(Query);
            LaboratorianGV.DataBind();
        }
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            LaboratorianGV.PageIndex = e.NewPageIndex;
            this.ShowLaboratorian();
        }
    }
}