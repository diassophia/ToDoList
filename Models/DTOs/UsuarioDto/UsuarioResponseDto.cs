namespace ToDoList.Models.DTOs.Usuario
{
    public class UsuarioResponseDto
    {
        public Guid Id { get; set; }
        public int Nome { get; set; } = "";
        public string Email { get; set; } = "";
        //public List<TarefaReponseDto> Tarefas { get; set; } = [];
    }
}
