using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HospitalIMS.Views
{
    public partial class Login : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con= new Models.Functions();
        }
        //Add this Overrideen method.
        public override void VerifyRenderingInServerForm(Control control)
        {

        }
        protected void EditBtn_Click(object sender, EventArgs e)
        {
            if (Rolecb.SelectedIndex == 0)
            {
                ErrMsg.InnerText = "Select a Role!!!";
            }
            else if (Rolecb.SelectedIndex == 1)
            {
                // ErrMsg.InnerText = "Select a Admin!!!";
                if (Emailtb.Value=="Admin@gmail.com" && passwordTb.Value=="Admin")
                {
                    string role = "Admin";
                    Session["uid"] = 1;
                    Session["role"] = role;
                    Session.Timeout = 10;
                    String url = "{0}/Doctors.aspx";
                    url = string.Format(url, role);

                    Response.Redirect(url);
                }
                else
                {
                    ErrMsg.InnerText = "Invalid Admin!!!";

                }
            }
            else if (Rolecb.SelectedIndex == 2)
            {
                string Query = "select * from DoctorTbl where DocEmail='{0}' and DocPass='{1}'";
                Query=string.Format(Query,Emailtb.Value, passwordTb.Value);
                DataTable dt=Con.GetDatas(Query);
                if (dt.Rows.Count==0)
                {
                  ErrMsg.InnerText = "Invalid Doctor!!!";
                }
                else
                {
                    string role = "Doctors";
                    Session["uid"] = dt.Rows[0][0].ToString();
                    Session["role"] = role;
                    Session.Timeout = 10;
                    String url = "{0}/Prescriptions.aspx";
                    url=string.Format(url,role);

                    Response.Redirect(url);
                }
            }
            else if (Rolecb.SelectedIndex == 3)
            {
              //  ErrMsg.InnerText = "Select a Receptionist!!!";
                string Query = "select * from ReceptionistTbl where RecEmail='{0}' and RecPassword='{1}'";
                Query = string.Format(Query, Emailtb.Value, passwordTb.Value);
                DataTable dt = Con.GetDatas(Query);
                if (dt.Rows.Count == 0)
                {
                    ErrMsg.InnerText = "Invalid Receptionist!!!";
                }
                else
                {
                    string role = "Receptionist";
                    Session["uid"] = dt.Rows[0][0].ToString();
                    Session["role"] = role;
                    Session.Timeout = 10;
                    String url = "{0}/Patients.aspx";
                    url = string.Format(url, role);

                    Response.Redirect(url);
                }
            }
            else if(Rolecb.SelectedIndex == 4)
            {
                //ErrMsg.InnerText = "Select a Laboratorian!!!";
                string Query = "select * from LaboratorianTbl where LabEmail='{0}' and LabPass='{1}'";
                Query = string.Format(Query, Emailtb.Value, passwordTb.Value);
                DataTable dt = Con.GetDatas(Query);
                if (dt.Rows.Count == 0)
                {
                    ErrMsg.InnerText = "Invalid Laboratorians!!!";
                }
                else
                {
                    string role = "Laboratorian";
                    Session["uid"] = dt.Rows[0][0].ToString();
                    Session["role"] = role;
                    Session.Timeout = 10;
                    String url = "{0}/LabTest.aspx";
                    url = string.Format(url, role);

                    Response.Redirect(url);
                }
            }
        }
    }
}