using appWeb1._2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace appWeb1._2.Controllers
{
    public class descripcionController : Controller
    {
        private readonly pruebadbContext _context;

        public descripcionController(pruebadbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var descripciontrabajo = (from d in _context.descripcionTrabajo
                                      join t in _context.Trabajo on d.id_trabajo equals t.idtrabajo
                                      select new
                                      {
                                          nombre_trabajo = t.titulotrabajo,
                                          requerimientos = d.requisitos,
                                          beneficio = d.beneficios,
                                          responsabilidades = d.responsabilidades,
                                          comentarios = d.comentarios,
                                      }).ToList();
            ViewData["descripcionTrabajo"] = descripciontrabajo;

            var comentariosuser = (from c in _context.seccioncoment
                                   join a in _context.administracionEmpresa on c.id_empresa equals a.id_perfil
                                   select new
                                   {
                                       nombreempresa = a.nombre_empresa,
                                       comentario = c.comentario,
                                       valoracion = c.valoracion,
                                   }


                                  ).ToList();
            ViewData["comentariosuser"] = comentariosuser;


            var comboadmin = (from a in _context.administracionEmpresa
                              select a).ToList();
            ViewData["listadoempresas"] = new SelectList(comboadmin, "id_perfil", "nombre_empresa");

            return View();
        }
        public IActionResult Crearcomentario(seccioncoment nuevocomentario)
        {
            _context.Add(nuevocomentario);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
