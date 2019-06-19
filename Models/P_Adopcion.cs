using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace proyecto_huellas.Models
{
    public class P_Adopcion
    {
        public int Id{get; set;}
        public string Usuario {get; set;}
        
    
        [Required (ErrorMessage = "Falta ingresar el número de telefono")]
        public string NumTelefono{get; set;}
        
        public string Imagen{get; set;}
        public string Descripcion{get; set;}
        
        public string Tipo{get; set;}

    }
}
