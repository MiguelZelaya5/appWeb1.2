using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol.Core.Types;
using System.ComponentModel.DataAnnotations;
namespace appWeb1._2.Models
{
    public class administracionEmpresa
    {
        [Key]
        public int id_perfil { get; set; }
        public string nombre_empresa { get; set; }

        public string descripcion_empresa { get; set; }

        public string correo { get; set; }
        public string mision { get; set; }
        public string vision { get; set; }
        
        public string detalle_contacto { get; set; }
        public string contrasena { get; set; }
    }
}
