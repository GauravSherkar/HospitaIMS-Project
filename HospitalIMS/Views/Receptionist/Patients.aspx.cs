using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalIMS.Views.Receptionist
{
    public partial class Patients : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con=new Models.Functions();
            ShowPatients();
        } 
       
        public void ShowPatients()
        {
            string Query = "select * from PatientTbl";
            PatGV.DataSource = Con.GetDatas(Query);
            PatGV.DataBind();
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
             
        }
        protected void EditBtn_Click(object sender, EventArgs e)
        {
            //update
            try
            {
                string patname = NameTb.Value;
                string patphone = PhoneTb.Value;
                string patgen = GenderTb.SelectedItem.Value;
                string patdob = DOBTb.Value;
                string patadd = AddressTb.Value;
                string patall = AllergyTb.Value;

                string Query = "update PatientTbl set PatName='{0}',PatPhone='{1}',PatGen='{2}',PatDob='{3}',PatAdd='{4}',PatAllergies='{5}' where Patid={6}";
                Query = string.Format(Query, patname, patphone, patgen, patdob, patadd, patall, PatGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(Query);
                ShowPatients();
                ErrMsg.InnerText = "Patient Updated SuccessFully";
                Key = 0;

                NameTb.Value = "";
                PhoneTb.Value = "";
                GenderTb.SelectedIndex = -1;
                DOBTb.Value = "";
                AddressTb.Value = "";
                AllergyTb.Value = "";

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
                string User = Session["uid"] as string;
                string patname = NameTb.Value;
                string patphone=PhoneTb.Value;
                string patgen = GenderTb.SelectedItem.Value;
                string patdob=DOBTb.Value;
                string patadd = AddressTb.Value;
                string patall=AllergyTb.Value;

                string Query = "insert into PatientTbl values('{0}','{1}','{2}','{3}','{4}','{5}',{6})";
                Query=string.Format(Query, patname, patphone, patgen, patdob, patadd, patall, User);
                Con.SetDatas(Query);
                ShowPatients();
                ErrMsg.InnerText = "Patient Add SuccessFully";

                NameTb.Value = "";
                PhoneTb.Value = "";
                GenderTb.SelectedIndex = -1;
                DOBTb.Value = "";
                AddressTb.Value = "";
                AllergyTb.Value = "";

            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameTb.Value=="")
                {
                    ErrMsg.InnerText = "Select a Doctors";
                }
                else
                {
                    string Query = "delete from PatientTbl where Patid={0}";
                    Query = string.Format(Query, PatGV.SelectedRow.Cells[1].Text);
                    Con.SetDatas(Query);
                    ShowPatients();
                    ErrMsg.InnerText = "Patient deleted SuccessFully";
                    Key = 0;

                    NameTb.Value = "";
                    PhoneTb.Value = "";
                    GenderTb.SelectedIndex = -1;
                    DOBTb.Value = "";
                    AddressTb.Value = "";
                    AllergyTb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
           
        }
        int Key = 0;
        protected void OnSelectedIndexChanged(object sender,EventArgs e)
        {
            //PatGV.PageIndex = e.NewPageIndex;
            //this.ShowPatients();

            NameTb.Value = PatGV.SelectedRow.Cells[2].Text;
            PhoneTb.Value= PatGV.SelectedRow.Cells[3].Text;
            GenderTb.SelectedItem.Value= PatGV.SelectedRow.Cells[4].Text;
            DOBTb.Value = PatGV.SelectedRow.Cells[5].Text;
            AddressTb.Value= PatGV.SelectedRow.Cells[6].Text;
            AllergyTb.Value= PatGV.SelectedRow.Cells[7].Text;

            if (NameTb.Value=="")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PatGV.SelectedRow.Cells[1].Text);
            }
           
        }
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            PatGV.PageIndex = e.NewPageIndex;
            this.ShowPatients();
        }
    }
}