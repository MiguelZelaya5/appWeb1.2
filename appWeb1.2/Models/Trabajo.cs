using System.ComponentModel.DataAnnotations;

namespace appWeb1._2.Models
{
    public class Trabajo
    {
        [Key]
        public int idtrabajo { get; set; }
        public string? titulotrabajo { get; set; }
        public string? nombreempresa { get; set; }
        public string? ubicacion { get; set; }
        public string? tipotrabajo { get; set; }
        public string? fechapublicacion { get; set; }
        public decimal? salario { get; set; }
        public string? nivelexperiencia { get; set; }
        public string? sectorlaboral { get; set; }
        public string? tipocontrato { get; set; }


    }
}
