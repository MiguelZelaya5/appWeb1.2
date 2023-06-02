using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol.Core.Types;
using System.ComponentModel.DataAnnotations;
namespace appWeb1._2.Models
{
    public class seccioncoment
    {
        [Key]
        public int id_comentario { get; set; }
        public int id_empresa { get; set; }

        public string comentario { get; set; }

        public int valoracion { get; set;}
    }
}
