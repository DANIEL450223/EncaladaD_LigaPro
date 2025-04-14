using EncaladaD_LigaPro.Models;

namespace EncaladaD_LigaPro.Repositorios
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> DevuelveListadoEquipos(){
            List<Equipo> equipos = new List<Equipo>();

            Equipo BSC = new Equipo
            {
                Id = 1,
                Nombre = "Barcelona",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0
            };


            Equipo LDU = new Equipo
            {
                Id = 2,
                Nombre = "Liga de Quito",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 1,
                PartidosPerdidos = 8
            };
            equipos.Add(BSC);
            equipos.Add(LDU);

            equipos = equipos.OrderByDescending(item => item.TotalPuntos).ToList();

            return equipos;
        }

        public Equipo DevuelveInformacionEquipo(int Id) 
        {
            var equipos = DevuelveListadoEquipos();
            var equipo = equipos.First(item => item.Id == Id);

            return equipo;
        }

        public bool ActualizarEquipo(Equipo Equipo) 
        {
            //Logica para actualizar
            return true;
        }
    }
}
