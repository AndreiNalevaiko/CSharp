namespace Aula1005_POO {

    class Cliente {

        // Atributo
        private string nome;
        private string cpf;

        // Propriedade
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }


        //Construtor
        public Cliente() { //construtor vazio

        }

        public Cliente(string nome) {
            Nome = nome;
        }

        public Cliente(string nome,  string cpf){
            nome = nome;
            cpf = cpf;
        }


    }
}
