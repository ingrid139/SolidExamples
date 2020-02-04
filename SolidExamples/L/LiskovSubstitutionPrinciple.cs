
namespace SolidExamples.L
{
    public class LiskovSubstitutionPrinciple
    {
        //Barbara Liskov 
        //Uma classe derivada deve ser substituível por sua classe base.
        //Passando parâmetro tanto a classe pai como a classe derivada, o código deve continuar funcionando

        public class A
        {
            public string getNome()
            {
                return "Meu nome é A";
            }
        }

        public class B : A
        {
            public string getNome()
            {
                return "Meu nome é B";
            }
        }

        public void impremeClassesAeB()
        {
            var objeto1 = new A();
            imprimeNome(objeto1);

            var objeto2 = new B();
            imprimeNome(objeto2);
        }
        

        public string imprimeNome(A objeto)
        {
            return objeto.getNome();
        }

    }
}
