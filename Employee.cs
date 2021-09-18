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
    public class Employee
    {
        // Connection String decleration
        private static string myconn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;


        // Class Properties Decleration
        public int Emp_ID { get; set; }
        public int Job_Role_ID { get; set; }
        public int Dept_ID { get; set; }
        public string Emp_FName { get; set; }
        public string Emp_LName { get; set; }
        public int Emp_Age { get; set; }
        public string Emp_Contact { get; set; }
        public string Emp_Gender { get; set; }
        public string Emp_email { get; set; }


        //Database Queries Decleration
        private const string SelectQuery = "SELECT * FROM Emp_details1";
        private const string InsertQuery = "INSERT INTO Emp_details1(Dept_ID,Job_Role_ID,Emp_FName,Emp_LName ,Emp_Age,Emp_Contact,Emp_Gender,Emp_email)VALUES(@Dept_ID,@Job_Role_ID,@Emp_FName,@Emp_LName,@Emp_Age,@Emp_Contact,@Emp_Gender,@Emp_email)";
        private const string UpdateQuery = "UPDATE Emp_details1 SET Dept_ID=@Dept_ID,Job_Role_ID=@Job_Role_ID,Emp_FName = @Emp_FName,Emp_LName = @Emp_LName,Emp_Age=@Emp_Age,Emp_Contact=@Emp_Contact,Emp_Gender=@Emp_Gender,Emp_email=@Emp_email WHERE  Emp_ID=@Emp_ID";
        private const string DeleteQuery = "DELETE FROM Dept_details where Emp_ID=@Emp_ID DELETE FROM Payroll_details where Emp_ID=@Emp_ID DELETE FROM Qualification_details where Emp_ID=@Emp_ID DELETE FROM Salary_details where Emp_ID=@Emp_ID DELETE FROM Emp_details1 WHERE  Emp_ID=@Emp_ID";


        // Public Methord Decleration
        public bool InsertEmployee(Employee employee)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(InsertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Dept_ID", employee.Dept_ID);
                    cmd.Parameters.AddWithValue("@Job_Role_ID", employee.Job_Role_ID);
                    
                    cmd.Parameters.AddWithValue("@Emp_FName", employee.Emp_FName);
                    cmd.Parameters.AddWithValue("@Emp_LName", employee.Emp_LName);
                    cmd.Parameters.AddWithValue("@Emp_Age", employee.Emp_Age);
                    cmd.Parameters.AddWithValue("@Emp_Contact", employee.Emp_Contact);
                    cmd.Parameters.AddWithValue("@Emp_Gender", employee.Emp_Gender);
                    cmd.Parameters.AddWithValue("@Emp_email", employee.Emp_email);
                    rows = cmd.ExecuteNonQuery();
                }
            }

            return (rows > 0) ? true : false;
        }

        public bool UpdateEmployee(Employee employee)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(UpdateQuery, con))
                {
                    
                    cmd.Parameters.AddWithValue("@Dept_ID", employee.Dept_ID);
                    cmd.Parameters.AddWithValue("@Job_Role_ID", employee.Job_Role_ID);
                    cmd.Parameters.AddWithValue("@Emp_FName", employee.Emp_FName);
                    cmd.Parameters.AddWithValue("@Emp_LName", employee.Emp_LName);
                    cmd.Parameters.AddWithValue("@Emp_Age", employee.Emp_Age);
                    cmd.Parameters.AddWithValue("@Emp_Contact", employee.Emp_Contact);
                    cmd.Parameters.AddWithValue("@Emp_Gender", employee.Emp_Gender);
                    cmd.Parameters.AddWithValue("@Emp_email", employee.Emp_email);
                    cmd.Parameters.AddWithValue("@Emp_ID", employee.Emp_ID);
                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false; ;
 
        }

        public bool DeleteEmployee(Employee employee)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myconn))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(DeleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Emp_ID", employee.Emp_ID);
                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false; ;
        }
        public DataTable GetEmployees()
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
