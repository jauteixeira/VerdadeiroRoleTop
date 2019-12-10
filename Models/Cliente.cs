using System;

namespace RoleTopOficial.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string CPF {get;set;}
        public string Telefone {get;set;}
        public string Senha {get;set;}
        public string Email {get;set;}

        public Cliente(){

        }
        public Cliente( string nome, string cpf, string telefone, string senha, string email)
        {

            this.Nome = nome;
            this.CPF = cpf;
            this.Telefone = telefone;
            this.Senha = senha;
            this.Email = email;

        
        }
    }
}