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
        public string Semestre { get; set; }
        public int Limite { get; set; }
        public int Tomado { get; set; }
        public int Disponible { get; set; }

        public Inscripciones()
        {
            InscripcionId = 0;
            Semestre = string.Empty;
            Limite = 0;
            Tomado = 0;
            Disponible = 0;
        }


    }
}
