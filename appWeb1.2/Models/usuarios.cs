using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace appWeb1._2.Models
{
    public class usuarios
    {
        [Key]
        public int id_usuario { get; set; }

        public string nombre { get; set; }

        public int edad { get; set; }

        public string genero { get; set; }

        public int valoracion { get; set; }

        public string valoracion_empresa { get; set; }
        
        
    }
}
