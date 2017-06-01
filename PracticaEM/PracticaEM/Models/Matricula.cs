using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaEM.Models
{
    public class Matricula
    {
        [Key]
        public int MatriculaId { get; set; }
        public string Mail { get; set; }
        public string Ano { get; set; }
        public string Nombre { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public int GrupoClaseId { get; set; }
        public virtual GrupoClase GrupoClase { get; set; }

        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; }
    }
}