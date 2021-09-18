using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    
    public class Depart2
    {
        private static string myconn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public int Dept_Id { get; set; }
        public string Dept_Name { get; set; }
        private const string SelectQuery = "SELECT * FROM Department";
        private const string InsertQuery = "INSERT INTO Department(Dept_Name)VALUES(@Dept_Name)";
        private const string UpdateQuery = "UPDATE Department SET Dept_Name = @DeptName WHERE Dept_ID=@Dept_ID";
        private const string DeleteQuery = "DELETE FROM Salary_Setting where Dept_ID=@Dept_ID DELETE FROM Emp_details1 where Dept_ID=@Dept_ID DELETE FROM Department WHERE  Dept_ID=@Dept_ID";


        // Public Methord Decleration
        public bool InsertDepartment(Depart2 dept)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(InsertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Dept_Name", dept.Dept_Name);
                    rows = cmd.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }

        public bool UpdateDepartment(Depart2 dept)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(UpdateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Dept_Name", dept.Dept_Name);
                    cmd.Parameters.AddWithValue("@Dept_ID", dept.Dept_Id);
                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false; ;

        }

        public bool DeleteDepartment(Depart2 dept)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(DeleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Dept_ID", dept.Dept_Id);
                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false; ;
        }
        public DataTable GetDepartment()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(SelectQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}

