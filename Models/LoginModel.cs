using System.ComponentModel.DataAnnotations;

namespace proyecto_huellas.Models
{
    public class LoginViewModel
    {
        [Required]
        public string Usuario { get; set; }

        
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}