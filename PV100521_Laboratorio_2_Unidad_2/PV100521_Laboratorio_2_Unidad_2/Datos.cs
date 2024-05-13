using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace PV100521_Laboratorio_2_Unidad_2
{
    public class Datos
    {
        private string connectionString = "Server=CHRISTIANP\\MSSQLSERVER2022;Initial Catalog=laboratorio2;User Id=sa;Password=Alquimista0xx;TrustServerCertificate=True;";

        public bool Ok()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    // Connection opened successfully
                    return true;
                }
            }
            catch (SqlException ex)
            {
                // Displaying the exception message
                Console.WriteLine("Error: " + ex.Message);
                // Returning false because there was an exception
                return false;
            }
        }

        public List<Data> Get()
        {
            List<Data> data = new List<Data>();

            string query = "select * from producto";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Data aData = new Data();
                        aData.CodigoProd = reader.GetInt32(0);
                        aData.NombreProd = reader.GetString(1);
                        aData.PrecioUnit = reader.GetDecimal(2);
                        aData.Unidades = reader.GetInt32(3);
                        data.Add(aData);
                    }
                }
                catch (SqlException ex)
                {
                    throw new Exception("Hay un error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }

            return data;
        }

        public Data Get(int CodigoProd)
        {

            string query = "select * from producto " +
                "where CodigoProd=@CodigoProd";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CodigoProd", CodigoProd);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    reader.Read();
                    
                    Data aData = new Data();
                    aData.CodigoProd = reader.GetInt32(0);
                    aData.NombreProd = reader.GetString(1);
                    aData.PrecioUnit = reader.GetDecimal(2);
                    aData.Unidades = reader.GetInt32(3);
                    
                    
                    reader.Close();
                    return aData;
                }
                catch (SqlException ex)
                {
                    throw new Exception("Hay un error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        public void AddData(int codigoProd, string nombreProd, decimal precioUnit, int unidades)
        {

            string query = "insert into producto(codigoprod, nombreprod, preciounit, unidades) values " +
                "(@codigoprod, @nombreprod, @preciounit, @unidades)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@codigoprod", codigoProd);
                command.Parameters.AddWithValue("@nombreprod", nombreProd);
                command.Parameters.AddWithValue("@preciounit", precioUnit);
                command.Parameters.AddWithValue("@unidades", unidades);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception("Hay un error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        public void UpdateData(int codigoProd, string nombreProd, decimal precioUnit, int unidades)
        {

            string query = "update producto set codigoprod=@codigoprod, nombreprod=@nombreprod, preciounit=@preciounit, unidades=@unidades";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@codigoprod", codigoProd);
                command.Parameters.AddWithValue("@nombreprod", nombreProd);
                command.Parameters.AddWithValue("@preciounit", precioUnit);
                command.Parameters.AddWithValue("@unidades", unidades);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    throw new Exception("Hay un error: " + ex.Message);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
        }

    }

    public class Data
    {
        public int CodigoProd { get; set; }
        public string NombreProd { get; set; }
        public decimal PrecioUnit { get; set; }
        public int Unidades { get; set; }
    }
}