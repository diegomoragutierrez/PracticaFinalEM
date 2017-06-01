using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaEM.Models
{
    public class Evaluacion
    {
        public enum ConvocatoriaType
        {
            Ordinaria,
            Extraordinaria
        }

        [Key]
        public int EvaluacionId { get; set; }
        public float NotaT1 { get; set; }
        public float NotaT2 { get; set; }
        public float NotaT3 { get; set; }
        public float NotaPr { get; set; }
        public float NotaTest { get; set; }
        public ConvocatoriaType Convocatoria { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}