namespace Aula1005_POO {
   public abstract class Pessoa {
        // Atributo
        private string nome;
        private string cpf;

        public string Nome { get; set; }
        public string Cpf { get; set; }

        //Construtor
        public Pessoa(){ //construtor vazio

        }

        public Pessoa(string nome){
            Nome = nome;
        }

        public Pessoa(string nome, string cpf){
            this.Nome = nome;
            this.Cpf = cpf;
        }

    }
}
