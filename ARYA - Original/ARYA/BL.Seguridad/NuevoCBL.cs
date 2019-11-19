using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BL.Seguridad.NuevoCBL;

namespace BL.Seguridad
{
    public class NuevoCBL
    {
        public BindingList<Cliente> ListaClientes { get; set; }

        public NuevoCBL()
        {

            ListaClientes = new BindingList<Cliente>();

    

        }

        public BindingList<Cliente> ObtenerClientes()
        {
            return ListaClientes;
        }



        public Resultado GuardarCliente(Cliente cliente)
        {
            var resultado = Validar(cliente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            if (cliente.Id == 0)

            { 
            cliente.Id = ListaClientes.Max(item => item.Id) + 1;

            }

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarCliente()
        {
            var nuevocliente = new Cliente();
            ListaClientes.Add(nuevocliente);

        }

        public bool EliminarCliente(int id)
        {
            foreach (var cliente in ListaClientes)
            {
                if (cliente.Id == id)
                {
                    ListaClientes.Remove(cliente);
                    return true;
                }


            }

            return false;
        }

        public class Cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Direcion { get; set; }
            public int CategoriaId { get; set; }
            public Categoria Categoria { get; set; }
            public int TipoId { get; set; }
            public Tipo Tipo { get; set; }
        }


        public class Resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }
        }


        private Resultado Validar(Cliente cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(cliente.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un nombre";
                resultado.Exitoso = false;
            }

            else if (string.IsNullOrEmpty(cliente.Telefono) == true)
            {
                resultado.Mensaje = "Ingrese un Numero de telefono";
                resultado.Exitoso = false;
            }

            else if (string.IsNullOrEmpty(cliente.Direcion) == true)
            {
                resultado.Mensaje = "Por favor ingrese una direccion ";
                resultado.Exitoso = false;
            }
                return resultado;
            
        }
    }
}



           
  

