using System.ComponentModel.DataAnnotations;

namespace NETCOREMVC.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Por favor, digite o seu email.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Digite um email válido.")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Digite o seu telefone.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Por favor, confirme o seu comparecimento ou não.")]
        public bool? WillAttend { get; set; }
    }
}
