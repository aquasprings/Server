using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentBO;
using System.Data.SqlClient;
using System.Data;


namespace StudentDAL
{
    public class DBOperations
    {
        public int AddStudent(Student sobj)
        {
            //ado.net code
            SqlConnection con = new SqlConnection("server=intvmsql01;user id=pj01test01;password=tcstvm;database=db01test01");
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_register_student_56", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sname", sobj.Name);
            cmd.Parameters.AddWithValue("@scont", sobj.Contact);
            cmd.Parameters.AddWithValue("@scity", sobj.City);

            cmd.Parameters.AddWithValue("@sid", 0);
            cmd.Parameters["@sid"].Direction = ParameterDirection.Output;

            int rowaffected = cmd.ExecuteNonQuery();

            if (rowaffected > 0)
            {
                int studentid = Convert.ToInt32(cmd.Parameters["@sid"].Value);
                return studentid;
            }
            else

                return 0;
        }
    }
}
