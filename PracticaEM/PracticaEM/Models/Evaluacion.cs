using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaEM.Models
{
    public class Evaluacion
    {
        [Key]
        public int EvaluacionId { get; set; }
        public float NotaT1 { get; set; }
        public float NotaT2 { get; set; }
        public float NotaT3 { get; set; }
        public float NotaPr { get; set; }
        public float NotaTest { get; set; }
        public String Convocatoria { get; set; }
    }
}