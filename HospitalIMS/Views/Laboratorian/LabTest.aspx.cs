using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalIMS.Views.Laboratorian
{
    public partial class LabTest : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con= new Models.Functions();
            ShowLabTest();
            GetPatients();
        }
        //please add this overidden method
        public override void VerifyRenderingInServerForm(Control control)
        {
            
        }
        public void ShowLabTest()
        {
            string Query = "Select * from LabTestTbl";
            LabTestGV.DataSource = Con.GetDatas(Query);
            LabTestGV.DataBind();
        }
        private void GetPatients()
        {
            string Query = "select * from PatientTbl";
            Patientcb.DataValueField = Con.GetDatas(Query).Columns["Patid"].ToString();
            Patientcb.DataTextField = Con.GetDatas(Query).Columns["PatName"].ToString();
            Patientcb.DataSource = Con.GetDatas(Query);
            Patientcb.DataBind();
        }
        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string TName = NameTb.Value;
                string TCost = TestCostTb.Value;

                string Query = "update LabTestTbl set TestName='{0}',TestCost='{1}' where Testid={2}";
                Query=string.Format(Query, TName, TCost, LabTestGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(Query);
                ErrMsg.InnerText = "Update Lab Test SuccessFully";
                ShowLabTest();
                Key = 0;

                NameTb.Value = "";
                TestCostTb.Value = "";
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
         
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
           
            try
            {
                string TName = NameTb.Value;
                string TCost = TestCostTb.Value;

                string Query = "insert into LabTestTbl values('{0}','{1}',{2})";
                Query=string.Format(Query, TName, TCost,1);
                Con.SetDatas(Query);
                ErrMsg.InnerText = "Lab Test Add SuccessFully";
                ShowLabTest();

                NameTb.Value = "";
                TestCostTb.Value = "";
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText= Ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameTb.Value=="")
                {
                    ErrMsg.InnerText = "Select A Lab Test";
                }
                else
                {
                    string Query = "delete from LabTestTbl where Testid={0}";
                    Query = String.Format(Query, LabTestGV.SelectedRow.Cells[1].Text);
                    Con.SetDatas(Query);
                    ErrMsg.InnerText = "Test Deleted SuccessFully";
                    ShowLabTest();
                    Key = 0;

                    NameTb.Value = "";
                    TestCostTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText=Ex.Message;
            }          
        }
        int Key = 0;
        protected void LabTestGV_SelectedIndexChanged(object sender, EventArgs e)
        {

            NameTb.Value = LabTestGV.SelectedRow.Cells[2].Text;
            TestCostTb.Value = LabTestGV.SelectedRow.Cells[3].Text;

            if (NameTb.Value=="")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(LabTestGV.SelectedRow.Cells[1].Text);
            }

        }
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ShowLabTest();
            LabTestGV.PageIndex=e.NewPageIndex;
            this.ShowLabTest();
        }
    }
}