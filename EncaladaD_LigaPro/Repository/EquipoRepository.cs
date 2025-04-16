using EncaladaD_LigaPro.Models;

namespace EncaladaD_LigaPro.Repositorios
{
    public class EquipoRepository
    {
        public static List<Equipo> Equipos = new List<Equipo>{


            new Equipo
            {
                Id = 1,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0,
                TotalPuntos = 30
            },


             new Equipo
            {
                Id = 2,
                Nombre = "Liga de Quito",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 1,
                PartidosPerdidos = 8,
                TotalPuntos = 4
            },
            };

        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            return Equipos;
        }

        public Equipo DevuelveInformacionEquipo(int Id) 
        {
            return Equipos.FirstOrDefault(e => e.Id == Id);
        }

        public bool ActualizarEquipo(int Id, Equipo equipoActual) 
        {
            var index = Equipos.FindIndex(e => e.Id == Id);
            if (index == 0) 
            {
                equipoActual.TotalPuntos = (equipoActual.PartidosGanados * 3) + equipoActual.PartidosEmpatados;
                Equipos[index] = equipoActual;
            return true;
        }
        return false;
        }
    }
}
