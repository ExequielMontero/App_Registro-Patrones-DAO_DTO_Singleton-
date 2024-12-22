using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using App_Registro.DTO;
namespace App_Registro.DAO
{
    internal class ClienteDAO
    {
        //En este patron las clases de las entidades solo utilizaran los metodos CRUD


        public List<ClientesDTO> VerRegistros(string condicion)
        {

            List<ClientesDTO> ListaGenerica = new List<ClientesDTO>();

            try
            {
                using (SqlConnection Conexion = new SqlConnection(@"Data Source=DESKTOP-3M720L6;Initial Catalog=PruebaPatrones;Integrated Security=True;TrustServerCertificate=True"))
                {
                    Conexion.Open();

                    using (SqlCommand comando = new SqlCommand("VerRegistros", Conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@Condicion", condicion);

                        using (SqlDataReader LeerFilas = comando.ExecuteReader())
                        {
                            while (LeerFilas.Read())
                            {
                                ListaGenerica.Add(new ClientesDTO
                                {
                                    ID = Convert.ToString(LeerFilas[0]),
                                    Nombre = Convert.ToString(LeerFilas[1]),
                                    Apellido = Convert.ToString(LeerFilas[2]),
                                    Direccion = Convert.ToString(LeerFilas[3]),
                                    Ciudad = Convert.ToString(LeerFilas[4]),
                                    Email = Convert.ToString(LeerFilas[5]),
                                    Telefono = Convert.ToString(LeerFilas[6]),
                                    Ocupacion = Convert.ToString(LeerFilas[7])

                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al obtener los registros", ex);
            }

            return ListaGenerica;
        }





        public void Insert()
        {

        }

        public void Edit()
        {

        }

        public void Delete()
        {

        }

    }
}
