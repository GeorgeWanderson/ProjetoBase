using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoExemplar.Entities
{
    public class Pessoa
    {
        // Propriedades da classe
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Saldo { get; set; }
        public string Descricao { get; set; }

        // Construtores
        public Pessoa() { }
        public Pessoa(string nome, int idade, double saldo, string descricao)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Saldo = saldo;
            this.Descricao = descricao;
        }
        

        // Métodos

        public static void Cadastrar()
        {

        }

        public static void Editar()
        {

        }

        public static void Listar()
        {

        }

        public static void Excluir()
        {

        }
    }
}
