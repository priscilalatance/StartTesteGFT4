namespace ExercicioPOO4.src.entities
{
    public class Funcionario
    {
       
        private string _nome;
        public string Nome {get => _nome; set =>_nome = value;}
        private int _idade;
        public int Idade {get => _idade; set => _idade = value;}
        private double _salario;
        public double Salario {get => _salario; set => _salario = value;} 

        
        public Funcionario(string nome, int idade, double salario)
        {
            (this.Nome, this.Idade, this.Salario) = (nome, idade, salario);
        }

        public virtual double bonificacao(double salario){
            return salario;
        }
    }
}