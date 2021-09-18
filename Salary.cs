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
    public class Salary
    { // Connection String decleration
        private static string myconn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;


        // Class Properties Decleration
        public int Salary_Id { get; set; }
        public int Emp_Id { get; set; }
        public float BasicSalary { get; set; }
        public float HRA { get; set; }
        public float DA { get; set; }
        public float OtherAllowance { get; set; }
        public float Bonus { get; set; }

        public float TDS { get; set; }
        public float PF { get; set; }



       
       


        //Database Queries Decleration
        private const string SelectQuery = "SELECT * FROM Salary_details";
        private const string InsertQuery = "INSERT INTO Salary_details(Emp_ID,BasicSalary,HRA,DA,OtherAllowance,Bonus,TDS,PF)VALUES(@Emp_ID,@BasicSalary,@HRA,@DA,@OtherAllowance,(SELECT Bonus FROM Salary_Setting INNER JOIN Emp_details1 ON Salary_Setting.Dept_ID=Emp_details1.Dept_ID and Salary_Setting.JobRoleID=Emp_details1.Job_Role_ID ),@TDS,@PF)";
        private const string UpdateQuery = "UPDATE Salary_details SET Emp_ID=@Emp_ID,BasicSalary=@BasicSalary,HRA=@HRA,DA=@DA,OtherAllowance=@OtherAllowance,Bonus=@Bonus,TDS=@TDS,PF=@PF WHERE  Salary_ID=@Salary_ID";
        private const string DeleteQuery = "DELETE FROM Payroll_details where Salary_ID=@Salary_ID DELETE FROM Salary_details where Salary_ID=@Salary_ID";


        // Public Methord Decleration
        public bool InsertSalary(Salary salary)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(InsertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Emp_Id", salary.Emp_Id);
                    cmd.Parameters.AddWithValue("@BasicSalary", salary.BasicSalary);
                    cmd.Parameters.AddWithValue("@HRA", salary.HRA);
                    cmd.Parameters.AddWithValue("@DA", salary.DA);
                    cmd.Parameters.AddWithValue("@OtherAllowance", salary.OtherAllowance);
                    cmd.Parameters.AddWithValue("@Bonus", salary.Bonus);
                    cmd.Parameters.AddWithValue("@TDS", salary.TDS);
                    cmd.Parameters.AddWithValue("@PF", salary.PF);


                    rows = cmd.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }

        public bool UpdateSalary(Salary salary)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(UpdateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Emp_Id", salary.Emp_Id);
                    cmd.Parameters.AddWithValue("@BasicSalary", salary.BasicSalary);
                    cmd.Parameters.AddWithValue("@HRA", salary.HRA);
                    cmd.Parameters.AddWithValue("@DA", salary.DA);
                    cmd.Parameters.AddWithValue("@OtherAllowance", salary.OtherAllowance);
                    cmd.Parameters.AddWithValue("@Bonus", salary.Bonus);
                    cmd.Parameters.AddWithValue("@TDS", salary.TDS);
                    cmd.Parameters.AddWithValue("@PF", salary.PF);

                    cmd.Parameters.AddWithValue("@Salary_ID", salary.Salary_Id);
                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false; ;

        }

        public bool DeleteSalary(Salary salary)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(DeleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Salary_Id", salary.Salary_Id);
                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false; ;
        }
        public DataTable GetSalary()
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

