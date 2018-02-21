using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentBO;
using StudentDAL;

namespace StudentUI
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            long contact = Convert.ToInt64(txtContact.Text);
            string city = ddlCity.SelectedItem.Text;
            Student s = new Student(name, contact, city);

            DBOperations dbobj = new DBOperations();
            int studentid = dbobj.AddStudent(s);
            //Response.Write("Added successfully with the id" + studentid);
            if (studentid > 0)
            {
                Response.Write("<script>alert('Added successfully with the id" + studentid + "')</script>");
            }
            else
                Response.Write("<script>alert('Error')</script>");

        }
    }
}
