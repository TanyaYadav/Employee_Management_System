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
    class SalarySet
    {
        private static string myconn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public int Dept_ID { get; set; }
        public int JobRoleID { get; set; }
        public float Bonus { get; set; }
        private const string SelectQuery = "SELECT * FROM Salary_Setting";
        private const string InsertQuery = "INSERT INTO Salary_Setting(Dept_ID,JobRoleID,Bonus)VALUES(@Dept_ID,@JobRoleID,@Bonus)";
        private const string UpdateQuery = "UPDATE Department SET Dept_ID=@Dept_ID,JobRoleID=@JobRoleID,Bonus=@Bonus WHERE Dept_ID=@Dept_ID and JobRoleID=@JobRoleID";
        private const string DeleteQuery = "DELETE FROM Department WHERE  Dept_ID=@DeptID and JobRoleID=@JobRoleID";


        // Public Methord Decleration
        public bool InsertsalarySet(SalarySet salset)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(InsertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Dept_ID", salset.Dept_ID);
                    cmd.Parameters.AddWithValue("@JobRoleID", salset.JobRoleID);
                    cmd.Parameters.AddWithValue("@Bonus", salset.Bonus);
                    rows = cmd.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }

        public bool UpdateSalarySet(SalarySet salset)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(UpdateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Dept_ID", salset.Dept_ID);
                    cmd.Parameters.AddWithValue("@JobRoleID", salset.JobRoleID);
                    cmd.Parameters.AddWithValue("@Bonus", salset.Bonus);
                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false; ;

        }

        public bool DeleteSalarySet(SalarySet salset)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(DeleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Dept_ID", salset.Dept_ID);
                    cmd.Parameters.AddWithValue("@JobRoleID", salset.JobRoleID);

                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false; ;
        }
        public DataTable GetSalarySet()
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
