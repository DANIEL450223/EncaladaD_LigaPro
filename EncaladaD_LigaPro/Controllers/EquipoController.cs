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
        public IActionResult EditarEquipo(int Id,Equipo equipo) 
        {
            try
            {
                _repository.ActualizarEquipo(Id, equipo);
                return RedirectToAction(nameof(List));
            }
            catch (Exception e) 
            {
                return View();
            }   
        }
    }
}
 