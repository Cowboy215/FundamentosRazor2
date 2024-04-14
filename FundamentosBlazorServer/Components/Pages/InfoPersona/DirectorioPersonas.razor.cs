using FundamentosBlazorServer.Modelos;

namespace FundamentosBlazorServer.Components.Pages.InfoPersona
{
    public partial class DirectorioPersonas
    {
        public List<Persona> Personas { get; set; }

        public DirectorioPersonas()
        {
            Personas = new List<Persona>
            {
              new Persona {
                Nombres = "Jose",
                Apellidos = "Montolla",
                Direcciones = new List<Direcciones> {
                    new Direcciones
                    {
                        TipoDireccion = "Casa",
                        Direccion = "Calle 53",
                        Departamento = "Risaralsa",
                        Ciudad = "Juarez"

                    },

                    new Direcciones
                    {
                        TipoDireccion = "Trabajo",
                        Direccion = "Centro Manantial",
                        Departamento = "Risaralsa",
                        Ciudad = "Juarez"

                    }

                }
              },
              new Persona {
                Nombres = "Johana",
                Apellidos = "Mendez",
                Direcciones = new List<Direcciones> {
                    new Direcciones
                    {
                        TipoDireccion = "Casa",
                        Direccion = "Calle 20",
                        Departamento = "Villas",
                        Ciudad = "Juarez"

                    }
                }
              },
              new Persona
              {
                Nombres = "Alexander",
                Apellidos = "Romo",
                Direcciones = new List<Direcciones>()
              }
            };
        }
    }
}
