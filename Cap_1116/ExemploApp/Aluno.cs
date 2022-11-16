using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploApp
{
    class Aluno
    {
        private string nome = "Sem nome";
        public Aluno(string nome)
        {
            if (nome != "") this.nome = nome;
            //if (nome != string.Empty) this.nome = nome;
        }
        public string Iniciais()
        {
            string[] vs = nome.Split();
            string r = "";
            foreach (string palavra in vs)
                r = r + palavra[0];
            return r;
        }
        public int[] Senha()
        {
            int[] vetor = new int[4];
            vetor[0] = 1000;
            vetor[1] = 1234;
            vetor[2] = 4321;
            vetor[3] = 9001;
            return vetor;
        }
    }
}
