using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
    class Cliente
    {
        private String nome, endereco, cep ;
        private int id;
        

        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Cep { get => cep; set => cep = value; }
        public int Id { get => id; set => id = value; }
       
        public Cliente(string nome, string endereco, string cep, int id)
        {
            {
                this.id = id;
                this.nome = nome;
                this.endereco = endereco;
                this.cep = cep;
                
            }
        }
    }
}
