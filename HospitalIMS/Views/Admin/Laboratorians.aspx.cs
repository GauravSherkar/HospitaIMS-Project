using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalIMS.Views.Admin
{
    public partial class Laboratorians : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowLaboratorians();

        }
        //Add This Overriden Method 
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        public void ShowLaboratorians()
        {
            string Query = "Select * from LaboratorianTbl";
            LabGV.DataSource=Con.GetDatas(Query);
            LabGV.DataBind();
        }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string LabName = NameTb.Value;
                string LabEmail = EmailTb.Value;
                String LabPassword = PasswordTb.Value;
                string LabPhone = PhoneTb.Value;
                string LabAddress = AddressTb.Value;
                string LabGender = GenderTb.SelectedItem.ToString();

                string Query = "insert into LaboratorianTbl values('{0}','{1}','{2}','{3}','{4}','{5}')";
                Query = String.Format(Query, LabName,LabEmail, LabPassword,LabPhone, LabAddress,LabGender);
                Con.SetDatas(Query);
                ShowLaboratorians();
                ErrMsg.InnerText = "Laboratorians Add SuccessFully";

                NameTb.Value = "";
                EmailTb.Value = "";
                PasswordTb.Value = "";
                PhoneTb.Value = "";
                AddressTb.Value = "";
                GenderTb.SelectedIndex = -1;
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }         
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string LabName = NameTb.Value;
                string LabEmail = EmailTb.Value;
                String LabPassword = PasswordTb.Value;
                string LabPhone = PhoneTb.Value;
                string LabAddress = AddressTb.Value;
                string LabGender = GenderTb.SelectedItem.ToString();

                string Query = "Update LaboratorianTbl Set LabName='{0}',LabEmail='{1}',LabPass='{2}',LabPhone='{3}',LabAddress='{4}',LabGen='{5}' where Labid={6}";
                Query = String.Format(Query, LabName, LabEmail, LabPassword, LabPhone, LabAddress, LabGender, LabGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(Query);
                ErrMsg.InnerText = "Update Laboratorian SuccessFully";
                ShowLaboratorians();
                Key = 0;

                NameTb.Value = "";
                EmailTb.Value = "";
                PhoneTb.Value = "";
                AddressTb.Value = "";
                GenderTb.SelectedIndex = -1;
                PasswordTb.Value = "";

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
                    ErrMsg.InnerText = "Select a Laboratorians!!!";
                }
                else
                {
                    String Query = "delete from LaboratorianTbl where Labid={0}";
                    Query = String.Format(Query, LabGV.SelectedRow.Cells[1].Text);
                    Con.SetDatas(Query);
                    ShowLaboratorians();
                    ErrMsg.InnerText = "Laboratorian Delete SuccessFully";
                    Key = 0;

                    NameTb.Value = "";
                    EmailTb.Value = "";
                    PhoneTb.Value = "";
                    AddressTb.Value = "";
                    GenderTb.SelectedIndex = -1;
                    PasswordTb.Value = "";
                }             
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText=Ex.Message;
            }
        }

        int Key = 0;
        protected void LabGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameTb.Value = LabGV.SelectedRow.Cells[2].Text;
            EmailTb.Value= LabGV.SelectedRow.Cells[3].Text;
            PasswordTb.Value = LabGV.SelectedRow.Cells[4].Text;
            PhoneTb.Value = LabGV.SelectedRow.Cells[5].Text;
            AddressTb.Value = LabGV.SelectedRow.Cells[6].Text;
            GenderTb.SelectedItem.Value = LabGV.SelectedRow.Cells[7].Text;
            if (NameTb.Value=="")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(LabGV.SelectedRow.Cells[1].Text);
            }                                
        }
        protected void OnPageIndexChanging(object sender,GridViewPageEventArgs e)
        {
            LabGV.PageIndex = e.NewPageIndex;
            this.ShowLaboratorians();
        }
    }
}