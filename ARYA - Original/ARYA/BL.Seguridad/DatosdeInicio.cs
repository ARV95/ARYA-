using BL.Seguridad;
using System.Data.Entity;

namespace BL.Seguridad
{
    internal class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = " admin";
            usuarioAdmin.Contrasena = "123";

            contexto.Usuarios.Add(usuarioAdmin);

            var Tipo1 = new Tipo();
            Tipo1.Descripcion = " Celulares ";
            contexto.Tipos.Add(Tipo1);

            var Tipo2 = new Tipo();
            Tipo2.Descripcion = " Computadoras ";
            contexto.Tipos.Add(Tipo2);




            base.Seed(contexto);


        }
    }
}