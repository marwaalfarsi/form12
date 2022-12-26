using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApplication12.DAL.Interface;

namespace WindowsFormsApplication12.DAL.entity
{
    class departments : IDepartment {
       
        public void insert(string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB.con;
            cmd.CommandText = "INSERT INTO Departmen(name) VALUE(@name)";
            cmd.Parameters.AddWithValue("@name", name);

            connDB.open();
            cmd.ExecuteNonQuery();
            connDB.closed();
        }

        public void delete(int id)
        {
            string query = "DELETE FROM Deprtmen WHERE id=@id";
            SqlCommand cmd = new SqlCommand(query, connDB.con);
            cmd.Parameters.AddWithValue("@id", id);
            connDB.open();
            cmd.ExecuteNonQuery();
            connDB.closed();
        }


        public void edit(int id, string name)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connDB.con;
            cmd.CommandText = "UPDATE Departmen SET name@name,  WHERE id=@id";
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@id", id);
            connDB.open();
            cmd.ExecuteNonQuery();
            connDB.closed();
        }

        public bool isExistName(string name)
        {
            string query = "SELECT COUNT(*) FROM Departmen where name LIKE @name";
            SqlCommand cmd = new SqlCommand(query, connDB.con);
            cmd.Parameters.AddWithValue("@name", name);
            connDB.open();
            Int32 count = (Int32)cmd.ExecuteScalar();
            connDB.closed();

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isUsedEmployee(int id)
        {
            string query = "SELECT COUNT(*) FROM employees WHERE DepID = @departnentsId";
            SqlCommand cmd = new SqlCommand(query, connDB.con);
            cmd.Parameters.AddWithValue("@departmentId", departmentId);
            connDB.open();
            Int32 count = (Int32)cmd.ExecuteScalar();
            connDB.closed();

            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable getAll()
        {
            string query = "SELECT * FROM Departmen";
            SqlCommand cmd = new SqlCommand(query, connDB.con);
            DataTable dt = new DataTable();
            connDB.open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connDB.closed();
            return dt;
        }

        public DataRow getById(int id)
        {
            string query = "SELECT * FROM Departmen WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query, connDB.con);
            cmd.Parameters.AddWithValue("@id", id);
            DataTable dt = new DataTable();
            connDB.open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            connDB.closed();

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0];
            }
            else
            {
                return null;
            }
        }
    }
}
