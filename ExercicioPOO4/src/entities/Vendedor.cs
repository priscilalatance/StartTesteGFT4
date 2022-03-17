namespace ExercicioPOO4.src.entities
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, double salario) : base( nome, idade, salario)
        {
        }
        public override double bonificacao(double salario){
            return salario + 3000.00;
        }         
    }
}