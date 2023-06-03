using appWeb1._2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace appWeb1._2.Controllers
{
    public class AdministracionController : Controller
    {
        private readonly pruebadbContext _context;

        public AdministracionController(pruebadbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string correo , string contrasena)
        {
            var validacion = (from a in _context.administracionEmpresa
                              where a.correo.Equals(correo) && a.contrasena.Equals(contrasena)
                              select a).FirstOrDefault();


            if (validacion != null)
            {
                ViewData["id_perfil"] = validacion.id_perfil;
                ViewData["nombre_empresa"] = validacion.nombre_empresa;
                ViewData["descripcion_empresa"] = validacion.descripcion_empresa;
                ViewData["correo"] = validacion.correo;
                ViewData["mision"] = validacion.mision;
                ViewData["vision"] = validacion.vision;
                ViewData["detalle_contacto"] = validacion.detalle_contacto;
                ViewData["contrasena"] = validacion.contrasena;
                bool mostrarFormulario2 = true;

                // Aquí puedes agregar la lógica para validar el correo y la contraseña
                // y establecer la variable mostrarFormulario2 en true si son válidos

                ViewData["mostrarFormulario2"] = "block";

            }
            //return View("~/Views/Administracion/Index.cshtml");
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

            return View();
        }
        public IActionResult buscarempresausuario(string correo, string contrasena)
        {
            


            return RedirectToAction("Index", new { correo,contrasena });


        }
        [HttpPost]
        public IActionResult ActualizarPerfil(int id_perfil, string nombre_empresa, string descripcion_empresa, string correo, string mision, string vision, string detalle_contacto, string contrasena)
        {
            // Obtener el registro correspondiente de la base de datos basándote en el id
            var administrador = _context.administracionEmpresa.FirstOrDefault(a => a.id_perfil == id_perfil);

            if (administrador != null)
            {
                // Actualizar los datos del administrador con los valores recibidos
                administrador.nombre_empresa = nombre_empresa;
                administrador.descripcion_empresa = descripcion_empresa;
                administrador.mision = mision;
                administrador.vision = vision;
                administrador.detalle_contacto = detalle_contacto;
                administrador.contrasena = contrasena;

                // Guardar los cambios en la base de datos
                _context.SaveChanges();
            }

            // Redireccionar a la página de inicio o a otra página según sea necesario
            return RedirectToAction("Index");
        }
        public IActionResult guardartrabajo(Trabajo nuevotrabajo)
        {
            _context.Add(nuevotrabajo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult guardarperfiladministracion(administracionEmpresa nuevaempresa)
        {
            _context.Add(nuevaempresa);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
