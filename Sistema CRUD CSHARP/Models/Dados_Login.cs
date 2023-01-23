using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_CRUD_CSHARP.Models
{
    internal class Dados_Login
    {
        public Dados_Login(int id, string login, string email, string senha, bool ativo)
        {
            Id = id;
            Login = login;
            Email = email;
            Senha = senha;
            Ativo = ativo;
        }

        public Dados_Login() : this(0, "", "", "", true) { }

        public int Id { get; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

    }
}
