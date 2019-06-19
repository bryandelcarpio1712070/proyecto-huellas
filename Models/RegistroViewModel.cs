using System.ComponentModel.DataAnnotations;

namespace proyecto_huellas.Models
{
    public class RegistroViewModel
    {
        [Required]
        public string Usuario { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}