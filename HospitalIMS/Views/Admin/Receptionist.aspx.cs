using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalIMS.Views.Admin
{
    public partial class Receptionist : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con=new Models.Functions();
            ShowReceptionist();
        }
        //Add This Overriden Method 
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        private void ShowReceptionist()
        {
            string Query = "select * from ReceptionistTbl";
            ReceptionistGV.DataSource = Con.GetDatas(Query);
            ReceptionistGV.DataBind();
        }
        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Rname = RecNameTb.Value;
                string Remail=RecEmailTb.Value;
                string Radd = RecAddressTb.Value;
                string RPhone= RecPhoneTb.Value;
                string Rpass=RecPasswordT.Value;
                
                string Query = "insert into ReceptionistTbl values('{0}','{1}','{2}','{3}','{4}')";
                Query=string.Format(Query,Rname,Remail,Radd,RPhone,Rpass);
                Con.SetDatas(Query);
                ErrMsg.InnerText = "Receptionist Added!!";
                ShowReceptionist();
                RecNameTb.Value="";
                 RecEmailTb.Value="";
                 RecAddressTb.Value = "";
                 RecPhoneTb.Value= "";
                 RecPasswordT.Value= "";
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }

        int Key = 0;
        protected void ReceptionistGV_SelectedIndexChanged(object sender, EventArgs e)
        {

            RecNameTb.Value = ReceptionistGV.SelectedRow.Cells[2].Text;
            RecEmailTb.Value = ReceptionistGV.SelectedRow.Cells[3].Text;
            RecAddressTb.Value = ReceptionistGV.SelectedRow.Cells[4].Text;
            RecPhoneTb.Value = ReceptionistGV.SelectedRow.Cells[5].Text;
            RecPasswordT.Value = ReceptionistGV.SelectedRow.Cells[6].Text;
            if (RecNameTb.Value=="")
            {
                Key = 0;
            }
            else
            {
                Key=Convert.ToInt32(ReceptionistGV.SelectedRow.Cells[1].Text);
            }
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {         
            try
            {
                string Rname = RecNameTb.Value;
                string Remail = RecEmailTb.Value;
                string Radd = RecAddressTb.Value;
                string RPhone = RecPhoneTb.Value;
                string Rpass = RecPasswordT.Value;

                string Query = "update ReceptionistTbl set RecName='{0}',RecEmail='{1}',RecAdd='{2}',RecPhone='{3}',RecPassword='{4}' where RecId={5}";
                Query = string.Format(Query, Rname, Remail, Radd, RPhone, Rpass,ReceptionistGV.SelectedRow.Cells[1].Text);
                Con.SetDatas(Query);
                ErrMsg.InnerText = "Receptionist Updated!!";
                ShowReceptionist();

                RecNameTb.Value = "";
                RecEmailTb.Value = "";
                RecAddressTb.Value = "";
                RecPhoneTb.Value = "";
                RecPasswordT.Value = "";
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
                if (RecNameTb.Value == "")
                {
                    ErrMsg.InnerText = "Select a Receptionist!!!";
                }
                else
                {
                    string Query = "delete from ReceptionistTbl where RecId={0}";
                    Query = string.Format(Query, ReceptionistGV.SelectedRow.Cells[1].Text);
                    Con.SetDatas(Query);
                    ShowReceptionist();
                    ErrMsg.InnerText = "Receptionist Deleted!!!";
                    Key = 0;
                    RecNameTb.Value = "";
                    RecEmailTb.Value = "";
                    RecAddressTb.Value = "";
                    RecPhoneTb.Value = "";
                    RecPasswordT.Value = "";
                }
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }
        protected void OnPageIndexChanging(object sender ,GridViewPageEventArgs e)
        {
            ReceptionistGV.PageIndex=e.NewPageIndex;
            this.ShowReceptionist();
        }

    }
}