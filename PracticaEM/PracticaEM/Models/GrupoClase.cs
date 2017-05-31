using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaEM.Models
{
    public class GrupoClase
    {
        [Key]
        public int GrupoClaseID { get; set; }
        public String Nombre { get; set; }
        public String Curso { get; set; }
    }
}