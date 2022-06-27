using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class LoginDto
    {
        [Required(ErrorMessage = "E-mail é um campo obrigatório para login")]
        [EmailAddress(ErrorMessage = "E-mail em formato invalido.")]
        [StringLength(100, ErrorMessage = "E-mail deve ter no maximo {1} caracteres.")]
        public string Email { get; set; }
    }
}
