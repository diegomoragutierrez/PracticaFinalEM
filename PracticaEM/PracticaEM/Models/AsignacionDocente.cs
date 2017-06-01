using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaEM.Models
{
    public class AsignacionDocente
    {
        [Key]
        public int AsigDocente { get; set; }
        public string Mail { get; set; }
        public string Ano { get; set; }
        public string Nombre { get; set; }
    }
}