using appWeb1._2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;



namespace appWeb1._2.Controllers
{
    public class usuariosController : Controller
    {
        private readonly pruebadbContext _context;

        public usuariosController(pruebadbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(string usuario, string aplicaTrabajo)
        {
            var nombreperfil = (from m in _context.usuarios
                            select m.nombre).Distinct().ToList();
            ViewData["nombreperfil"] = new SelectList(nombreperfil, "nombre");

            var tipoTrabjo = (from m in _context.Trabajo
                                select m.titulotrabajo).Distinct().ToList();
            ViewData["tipoTrabjo"] = new SelectList(tipoTrabjo, "titulotrabajo");

            var dataPerfilTrabajo = (from c in _context.Trabajo
                                select new
                                {
                                    titulotrabajo = c.titulotrabajo,
                                    nombreempresa = c.nombreempresa,
                                    
                                    trabajo = c.tipotrabajo,
                                    
                                }).ToList();

            ViewData["dataPerfilTrabajo"] = dataPerfilTrabajo;

            var gnero = (from m in _context.usuarios
                              select m.genero).Distinct().ToList();
            ViewData["gnero"] = new SelectList(gnero, "genero");




            return View();




        }
        public IActionResult guardarDatos(usuarios nuevoDato)
        {
            _context.Add(nuevoDato);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

       

    }
}
