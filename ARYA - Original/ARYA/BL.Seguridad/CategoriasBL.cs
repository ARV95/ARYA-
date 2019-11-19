using System.ComponentModel;
using System.Data.Entity;

namespace BL.Seguridad
{
    public class CategoriasBL
    {


            Contexto _contexto;

            public BindingList<Categoria> ListaCategorias { get; set; }

            public CategoriasBL()
            {
                _contexto = new Contexto();
                ListaCategorias = new BindingList<Categoria>();


            }

            public BindingList<Categoria> ObtenerTipos()
            {
                _contexto.Tipos.Load();
                ListaCategorias = _contexto.Categorias.Local.ToBindingList();

                return ListaCategorias;
            }
        }
}