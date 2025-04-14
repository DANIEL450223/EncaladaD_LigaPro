using EncaladaD_LigaPro.Models;
using EncaladaD_LigaPro.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace EncaladaD_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public EquipoRepository _repository;

        public EquipoController()
        {
            _repository = new EquipoRepository();
        }

        public IActionResult List()
        {
            var equipos = _repository.DevuelveListadoEquipos();
            return View(equipos);
        }

        public IActionResult EditarEquipo(int Id)
        {
            var equipo = _repository.DevuelveInformacionEquipo(Id);
             
            return View(equipo);
        }

        [HttpPost]
        public IActionResult EditarEquipo(Equipo equipo) 
        {
            try
            {
                var actualizar = _repository.ActualizarEquipo(equipo);
                return View();
            }
            catch (Exception e) 
            {
                throw;
            }   
        }
    }
}
 