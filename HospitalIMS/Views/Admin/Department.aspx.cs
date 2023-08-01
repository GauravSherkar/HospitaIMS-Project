using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalIMS.Views.Admin
{
    public partial class Department : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con=new Models.Functions(); 

        }
        public override void VerifyRenderingInServerForm(Control control)
        {
        }
     
        protected void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeptNameTb.Value=="")
                {
                    ErrMsg.InnerText = "Pleased Filled the data";
                }
                else
                {
                    string Deptname = DeptNameTb.Value;
                    string Description = DescriptionTb.Value;
                    string Status = StatusTb.SelectedItem.ToString();

                    string Query = "insert into DepartmentTbl values('{0}','{1}','{2}')";
                    Query = String.Format(Query, Deptname, Description, Status);
                    Con.SetDatas(Query);
                    ErrMsg.InnerText = "Department Add Successfully";
                }
                
            }
            catch (Exception ex)
            {
                ErrMsg.InnerText = ex.Message;
            }
            DeptNameTb.Value = "";
            DescriptionTb.Value = "";
            StatusTb.SelectedIndex = -1;
        }

        protected void DeptList_Click(object sender, EventArgs e)
        {
            Response.Redirect("DepartmentLists.aspx");
        }

      
    }
}