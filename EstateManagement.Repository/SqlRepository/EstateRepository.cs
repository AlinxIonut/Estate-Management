using EstateManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace EstateManagement.Repository.SqlRepository
{
    internal class EstateRepository : IRepository<Estate>
    {
        //cod de conectare la baza de date, executarea instructiunilor respective (SELECT, UPDATE, INSERT, DELETE)

         

        public Estate Create(Estate value)
        {

            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            var sql = "Insert into Estate values('" + value.Name + "','" + value.Address + "','" + value.Price + "','" + value.Type + "','" + value.CreateDate + "','" + value.OwnerId + "')";
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
            var sql = "delete Estate where ID=@id";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
            
                    cmd.ExecuteNonQuery();
                
                

            }
        }

        public List<Estate> GetAll()
        {
            var result = new List<Estate>();
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;  
            var sql = "SELECT * FROM Estate";

            using (var connection = new SqlConnection(connectionString)) 
            {
               
                connection.Open();

               
                using (var reader = new SqlCommand(sql, connection))
                {
                    var queryResult = reader.ExecuteReader(); 
                    while (queryResult.Read())
                    {
                        var estate = GetEstateFrom(queryResult);
                        result.Add(estate);
                    }
                    return result;
                }
            }
        }

        private Estate GetEstateFrom(SqlDataReader row)
        {
          
            return new Estate()
            {
        
                Id = (int)row["ID"],
                Name = (string)row["Name"],
                Address = (string)row["Adress"],
                Price = (int)row["Price"],
                Type = (string)row["Type"],
                CreateDate = Convert.ToDateTime(row["Date"]),
                OwnerId = (int)row["OwnerID"],
                
        };
    }  
       
        

        public Estate GetById(int id)
        {
            //SELECT * FROM Estate WHERE EstateId = {id}....
            throw new NotImplementedException(); 
        }

        public Estate Update(Estate value)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            var sql = "update Estate set Name=@name, Adress=@adress,Price=@price,Type=@type,Date=@date,OwnerId=@ownerId where ID=@id";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = value.Name;
                cmd.Parameters.Add("@adress", SqlDbType.NVarChar).Value = value.Address;
                cmd.Parameters.Add("@price", SqlDbType.BigInt).Value = value.Price;
                cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = value.Type;
                cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = value.Id;
                cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = value.CreateDate;
                cmd.Parameters.Add("@ownerId", SqlDbType.BigInt).Value = value.OwnerId;
                cmd.ExecuteNonQuery();
                return value;
            }
        }

      
    }
}
