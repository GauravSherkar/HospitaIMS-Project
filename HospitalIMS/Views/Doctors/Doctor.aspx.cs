using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalIMS.Views.Doctors
{
    public partial class Doctor : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con=new Models.Functions();           
            ShowDoctors();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            
        }
        public void ShowDoctors()
        {
            string Query = "Select * from DoctorTbl";
            DoctorGV.DataSource = Con.GetDatas(Query);
            DoctorGV.DataBind();
        }
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DoctorGV.PageIndex= e.NewPageIndex;
            this.ShowDoctors();
        }
    }
}