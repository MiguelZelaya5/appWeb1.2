using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol.Core.Types;
using System.ComponentModel.DataAnnotations;
namespace appWeb1._2.Models
{
    public class descripcionTrabajo
    {
        [Key]
        public int id_descripcion { get; set; }
        public int id_trabajo { get; set; }

        public string nombre_trabajo { get; set; }
        public string requisitos { get; set; }

        public string beneficios { get; set; }

        public string responsabilidades { get; set; }

        public string comentarios { get; set; }

    }
}
