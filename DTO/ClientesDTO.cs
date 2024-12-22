using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Registro.DTO
{
    internal class ClientesDTO
    {
        /*En el patron DTO, este tipo de clases es conocida como objeto de 
         * valores, y su estructura solo contiene atributos y propiedades. 
         * Tambien puede contener constructores pero no comportamientos.*/

        string _ID;
        string _Nombre;
        string _Apellido;
        string _Direccion;
        string _Ciudad;
        string _Email;
        string _Telefono;
        string _Ocupacion;

        public string ID { get => _ID; set => _ID = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Ciudad { get => _Ciudad; set => _Ciudad = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Ocupacion { get => _Ocupacion; set => _Ocupacion = value; }
    }
}
