using System;

namespace SolidExamples.O
{
    public class ViolationOpenClosedPrinciple
    {
        public class ContratoClt : Funcionario
        {
            public ContratoClt() : base() { }
            public override decimal salario()
            {
                return 5000;
            }
            public override decimal bolsaAuxilio()
            {
                // # ISP
                throw new NotImplementedException();
            }

        }

        public class Estagio : Funcionario
        {
            public override decimal salario()
            {
                // # ISP
                throw new NotImplementedException();
            }
            public override decimal bolsaAuxilio()
            {
                return 250;
            }
        }

        public class PJ : Funcionario
        {
            public override decimal salario()
            {
                throw new NotImplementedException();
            }
            public override decimal bolsaAuxilio()
            {
                return 250;
            }
        }


        public class FolhaDePagamento
        {
            protected decimal saldo;
    
            public void calcular(Funcionario funcionario)
            {
                if ( funcionario.GetType() == typeof(ContratoClt) ) {
                    this.saldo = funcionario.salario();
                } else if (funcionario.GetType() == typeof(Estagio) ) {
                    this.saldo = funcionario.bolsaAuxilio();
                }
                //if PJ... introduzir bugs 
            }
        }

        public abstract class Funcionario 
        {
            public int Cpf { get; set; }

            public abstract decimal salario();
            public abstract decimal bolsaAuxilio();
        }

    }
}
