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
    public class JobClass
    {
        private static string myconn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public int Job_Role_ID { get; set; }
        public string Job_Role_name { get; set; }
        private const string SelectQuery = "SELECT * FROM Job_Role";
        private const string InsertQuery = "INSERT INTO Job_Role(Job_Role_name)VALUES(@Job_Role_name)";
        private const string UpdateQuery = "UPDATE Job_Role SET Dept_Name = @DeptName WHERE Job_Role_ID=@Job_Role_ID";
        private const string DeleteQuery = "DELETE FROM Salary_Setting WHERE  Job_Role_ID=@Job_Role_ID DELETE FROM Emp_details1 WHERE  Job_Role_ID=@Job_Role_IDDELETE FROM Job_Role WHERE  Job_Role_ID=@Job_Role_ID";


        // Public Methord Decleration
        public bool InsertJobRole(JobClass job)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(InsertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Job_Role_name", job.Job_Role_name);
                    rows = cmd.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }

        public bool UpdateJobRole(JobClass job)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(UpdateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Job_Role_name", job.Job_Role_name);
                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false; ;

        }

        public bool DeleteJobRole(JobClass job)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(DeleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Job_Role_ID", Job_Role_ID);
                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false; ;
        }
        public DataTable GetJobRole()
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

