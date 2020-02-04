
namespace SolidExamples.O
{
    public class OpenClosedPrinciple
    {
        //preza que uma classe deve estar fechada para alteração e aberta para extensão.
        //Tio Bob - Separe o comportamento extensível por trás de uma interface e inverta as dependências.

        public interface Remuneravel
        {
            decimal remuneracao();
        }

        public class ContratoClt : Remuneravel
        {
            public decimal remuneracao()
            {
                return 5000;
            }
        }

        public class Estagio : Remuneravel
        {
            public decimal remuneracao()
            {
                return 250;
            }
        }



        public class FolhaDePagamento
        {
            protected decimal saldo;
    
            public void calcular(Remuneravel funcionario)
            {
                this.saldo = funcionario.remuneracao();
            }
        }
    }
}
