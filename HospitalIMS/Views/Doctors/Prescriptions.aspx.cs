using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalIMS.Views.Doctors
{
    public partial class Prescriptions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            GetTest();
            GetPatients();
            GetDoctor();
        }
        Models.Functions Con;
       
        public override void VerifyRenderingInServerForm(Control control)
        {
    
        }
        
       
        private void GetTest()
        {
            string Query = "select * from LabTestTbl";
            Testcb.DataValueField = Con.GetDatas(Query).Columns["Testid"].ToString();
            Testcb.DataTextField = Con.GetDatas(Query).Columns["TestName"].ToString();
            Testcb.DataSource = Con.GetDatas(Query);
            Testcb.DataBind();
        }
        private void GetPatients()
        {
            string Query = "select * from PatientTbl";
            Patientcb.DataValueField = Con.GetDatas(Query).Columns["Patid"].ToString();
            Patientcb.DataTextField = Con.GetDatas(Query).Columns["PatName"].ToString();
            Patientcb.DataSource = Con.GetDatas(Query);
            Patientcb.DataBind();
        }
        private void GetDoctor()
        {
            string Query = "select * from DoctorTbl";
            DocNameTb.DataValueField = Con.GetDatas(Query).Columns["Docid"].ToString();
            DocNameTb.DataTextField = Con.GetDatas(Query).Columns["DocName"].ToString();
            DocNameTb.DataSource = Con.GetDatas(Query);
            DocNameTb.DataBind();
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            if (CostTb.Value=="")
            {
                ErrMsg.InnerText = "Pleased filled the all values";
            }
            else
            {
                // string Doc = SelectedValue.ToString();
               // int Doc = 301;
                string Dname = DocNameTb.SelectedValue.ToString();
                string pat = Patientcb.SelectedValue.ToString();
                string medici = MedicineTb.Value;
                string lab = Testcb.SelectedValue.ToString();
                string cost = CostTb.Value;


                string Query = "insert into PrescriptionTbl values('{0}','{1}','{2}','{3}','{4}')";
                Query = string.Format(Query, Dname, pat, medici, lab, cost);
                Con.SetDatas(Query);

                ErrMsg.InnerText = "Prescription Add SuccessFully";

                Patientcb.SelectedIndex = -1;
                MedicineTb.Value = "";
                Testcb.SelectedIndex = -1;
                CostTb.Value = "";
            }
           

        }

        protected void DeptList_Click(object sender, EventArgs e)
        {
            Response.Redirect("PrescriptionList.aspx");
        }
    }
}