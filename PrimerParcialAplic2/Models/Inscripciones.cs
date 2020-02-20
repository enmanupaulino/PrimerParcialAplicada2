using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcialAplic2.Models
{
    public class Inscripciones
    {
    

        [Key]
        public int InscripcionId { get; set; }
        [Required(ErrorMessage = "El Semestre no puede estar vacio!")]
        public string Semestre { get; set; }
        public int Limite { get; set; }
        [Required(ErrorMessage ="no puede estar vacio")]
        [Range(minimum:1,maximum:27, ErrorMessage ="Debe de estar en un intervalo de 1 a 27")]
        public int Tomado { get; set; }
        public int Disponible { get; set; }

        public Inscripciones()
        {
            InscripcionId = 0;
            Semestre = string.Empty;
            Limite = 27;
            Tomado = 0;
            Disponible = 0;
        }


    }
}
