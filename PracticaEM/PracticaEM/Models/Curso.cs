using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaEM.Models
{
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }
        public string Ano { get; set; }
        public string Nombre { get; set; }
    }
}