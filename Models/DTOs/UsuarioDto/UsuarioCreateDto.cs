using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models.DTOs.Usuario
{
    public class UsuarioCreateDto
    {
        [Required, MinLength(3), MaxLength(50)]
        public int Nome { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MinLength(6), MaxLength(16)]
        public string Senha { get; set; }

    }
}
