using System.ComponentModel.DataAnnotations;

namespace ProjetoFuncionario.Models
{
    public class FuncionarioModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o E-mail")]
        [EmailAddress(ErrorMessage = "Inforem o email correto para prosseguir")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a profissão")]
        public string Profissao { get; set; }

        [Required(ErrorMessage = "Informe o Tempo de experiência")]
        public string TempoExperiencia { get; set; }

        [Required(ErrorMessage = "Informe o Salário")]
        public decimal Salario { get; set; }
    }
}
