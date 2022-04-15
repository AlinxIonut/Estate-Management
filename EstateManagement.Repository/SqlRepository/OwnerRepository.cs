using EstateManagement.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstateManagement.Repository.SqlRepository
{
    internal class OwnerRepository : IRepository<Owner>
    {
       
  
        public Owner Create(Owner value)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            var sql = "Insert into Owner values('" + value.Name + "','" + value.Email + "','" + value.Phone + "','" + value.Cnp + "')";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.ExecuteNonQuery();
                return value;
            }
        }
        public void Delete(int id)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            var sql = "delete Owner where ID=@id";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
                cmd.ExecuteNonQuery(); 
                
               
            }
        }

        public List<Owner> GetAll()
        {

            var result = new List<Owner>();
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;  //string de conectare la baza de date sql (a se obtine din app.config!)
            var sql = "SELECT * FROM Owner";

            using (var connection = new SqlConnection(connectionString)) 
            {
               
                connection.Open();

                //vom crea un obiect de tip reader pentru executarea unui select
                using (var reader = new SqlCommand(sql, connection))
                {
                    var queryResult = reader.ExecuteReader(); 
                    while (queryResult.Read())
                    {
                        var owner = GetOwnerFrom(queryResult);
                        result.Add(owner);
                    }
                    return result;
                }
            }



        
        }
        private Owner GetOwnerFrom(SqlDataReader row)
        {
            //......
            return new Owner()
            {
                Id = (int)row["Id"],
               Name = (string)row["Name"],
               Email = (string)row["Email"],
               Phone=(string)row["Phone"],
               Cnp=(string)row["CNP"]
            };
        }

            public Owner GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Owner Update(Owner value)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            var sql = "update Owner set Name=@name, Email=@email,Phone=@phone,CNP=@cnp where ID=@id"; 

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = value.Name;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = value.Email;
                cmd.Parameters.Add("@phone", SqlDbType.BigInt).Value = value.Phone;
                cmd.Parameters.Add("@cnp", SqlDbType.NVarChar).Value = value.Cnp;
                cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = value.Id;
                cmd.ExecuteNonQuery();
                return value;
            }
        }

     
    }
}
