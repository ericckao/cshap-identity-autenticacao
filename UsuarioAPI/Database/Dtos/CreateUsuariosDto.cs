using System.ComponentModel.DataAnnotations;

namespace UsuarioAPI.Database.Dtos
{
    public class CreateUsuariosDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public DateTime DataDeNascimento { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }



    }
}
