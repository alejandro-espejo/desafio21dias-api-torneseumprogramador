using System;

namespace console_desafio21dias_api
{
    class Aluno
    {
        private string nome;
        public string Nome {
            get 
            {
                return this.nome;
            }
            set
            {
                this.nome = value.ToUpper();
            } 
        }

        public string Matricula { get; set; }

        private List<double> notas;
        public List<double> Notas { 
            get 
            {
                if (this.notas == null) this.notas = new List<double>();
                return this.notas;
            }
            set 
            {

            }
        }

        public double CalcularMedia()
        {
            var somaNotas = 0.0;
            foreach(var nota in this.Notas) {
                somaNotas += nota;
            }
            return somaNotas / this.Notas.Count;
        }

        public string Situacao() 
        {
            return this.CalcularMedia() >= 7 ? "APROVADO" : "REPROVADO";
        }
    }
}
