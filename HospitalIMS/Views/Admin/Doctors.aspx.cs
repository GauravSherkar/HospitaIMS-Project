using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalIMS.Views.Admin
{
    public partial class Doctors : System.Web.UI.Page
    {
        Models.Functions Con;  
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowDoctors();
        }
        //Add This Overriden Method 
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
         public  void ShowDoctors() 
         {
            string Query = "Select * from DoctorTbl";
            DoctorGV.DataSource = Con.GetDatas(Query);
            DoctorGV.DataBind();
         }

        protected void AddBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                string Dname = DocNameTb.Value;
                string DPhone=DocPhoneTb.Value;
                string DExp=DocExpTb.Value;
                string DSpeci=SpecilisationTb.Value;
                string DGen=GenderTb.SelectedItem.ToString();
                string Dadd=AddressTb.Value;
                String DDob = DOBTb.Value;
                string Dpass=Password.Value;
                string DEmail=EmailTb.Value;

                string Query = "insert into DoctorTbl values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')";
                Query=string.Format(Query, Dname, DPhone,DExp,DSpeci,DGen,Dadd, DDob,Dpass,DEmail);
                Con.SetDatas(Query);
                ErrMsg.InnerText = "Doctor Add SuccessFully";
                ShowDoctors();
                DocNameTb.Value = "";
                DocPhoneTb.Value = "";
                DocExpTb.Value = "";
                SpecilisationTb.Value = "";                
                GenderTb.SelectedItem.Value = "";
                AddressTb.Value = "";
                DOBTb.Value = "";
                Password.Value = "";
                EmailTb.Value = "";

            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(DocNameTb.Value =="")
                {
                    ErrMsg.InnerText = "Select A Doctors";
                }
                else
                {
                    string Query = "delete from DoctorTbl where Docid={0}";
                    Query = string.Format(Query, DoctorGV.SelectedRow.Cells[1].Text);
                    Con.SetDatas(Query);
                    ShowDoctors();
                    ErrMsg.InnerText = "Successfully Delete Doctors";
                    Key = 0;

                    DocNameTb.Value = "";
                    DocPhoneTb.Value = "";
                    DocExpTb.Value = "";
                    SpecilisationTb.Value = "";
                    GenderTb.SelectedIndex = -1;
                    AddressTb.Value = "";
                    DOBTb.Value = "";
                    Password.Value = "";
                    EmailTb.Value = "";

                }
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;          
            }

        }
        int Key = 0;
        protected void DoctorGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocNameTb.Value = DoctorGV.SelectedRow.Cells[2].Text;
            DocPhoneTb.Value = DoctorGV.SelectedRow.Cells[3].Text;
            DocExpTb.Value = DoctorGV.SelectedRow.Cells[4].Text;
            SpecilisationTb.Value = DoctorGV.SelectedRow.Cells[5].Text;
            GenderTb.SelectedItem.Value = DoctorGV.SelectedRow.Cells[6].Text;
            AddressTb.Value = DoctorGV.SelectedRow.Cells[7].Text;
            DOBTb.Value = DoctorGV.SelectedRow.Cells[8].Text;
            Password.Value = DoctorGV.SelectedRow.Cells[9].Text;
            EmailTb.Value = DoctorGV.SelectedRow.Cells[10].Text;
            if (DocNameTb.Value=="")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DoctorGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Dname = DocNameTb.Value;
                string DPhone = DocPhoneTb.Value;
                string DExp = DocExpTb.Value;
                string DSpeci = SpecilisationTb.Value;
                string DGen = GenderTb.SelectedItem.ToString();
                string Dadd = AddressTb.Value;
                String DDob = DOBTb.Value;
                string Dpass = Password.Value;
                string DEmail=EmailTb.Value;
                string Query = "update DoctorTbl set DocName='{0}',DocPhone='{1}',DocExp='{2}',DocSpec='{3}',DocGen='{4}',DocAdd='{5}',DocDob='{6}',DocPass='{7}',DocEmail='{8}' where Docid={9}";
                Query=string.Format(Query, Dname, DPhone, DExp, DSpeci, DGen, Dadd, DDob,Dpass,DEmail, DoctorGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(Query);
                ErrMsg.InnerText = "Doctor Updated SuccessFully";
                ShowDoctors();
                Key=0;





                DocNameTb.Value = "";
                DocPhoneTb.Value = "";
                DocExpTb.Value = "";
                SpecilisationTb.Value = "";
                GenderTb.SelectedIndex = -1;
                AddressTb.Value = "";
                DOBTb.Value = "";
                Password.Value = "";
                EmailTb.Value = "";
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText=Ex.Message;
            }
        }
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            DoctorGV.PageIndex = e.NewPageIndex;
            this.ShowDoctors();
        }
    }
}