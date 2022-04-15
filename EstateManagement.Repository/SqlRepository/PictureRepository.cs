using EstateManagement.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateManagement.Repository.SqlRepository
{
    internal class PictureRepository : IRepository<Picture>
    {
        public Picture Create(Picture value)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            var sql = "Insert into Pictures values('" + value.Name + "','" + value.CreateDate + "','" + value.Size + "','" + value.EstateId +"')";
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
            var sql = "delete Pictures where ID=@id";
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
                cmd.ExecuteNonQuery();

            }
        }

       
       
        public List<Picture> GetAll()
        {
            throw new NotImplementedException();
        }

        public Picture GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Picture Update(Picture value)
        {
            throw new NotImplementedException();
        }
    }
}
