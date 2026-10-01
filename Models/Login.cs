using System.ComponentModel.DataAnnotations;

namespace EnvioEmail.Models
{
    public class Login
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
    }
}
