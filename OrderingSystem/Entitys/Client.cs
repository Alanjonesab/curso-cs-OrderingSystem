using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSystem.Entitys
{
    class Client
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string nome, string email, DateTime birthDate)
        {
            Nome = nome;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Nome);
            sb.Append(" (");
            sb.Append(BirthDate);
            sb.Append(") - ");
            sb.Append(Email);

            return sb.ToString();
        }
    }
}
