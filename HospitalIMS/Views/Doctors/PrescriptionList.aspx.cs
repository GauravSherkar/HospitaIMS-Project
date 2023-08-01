using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalIMS.Views.Doctors
{
    public partial class PrescriptionList : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();   
            ShowPrescription();

        }
        private void ShowPrescription()
        {
            String Query = "Select * from PrescriptionTbl";
            PresGV.DataSource = Con.GetDatas(Query);
            PresGV.DataBind();
        }
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            PresGV.PageIndex=e.NewPageIndex;
            this.ShowPrescription();
        }

        protected void PresGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}