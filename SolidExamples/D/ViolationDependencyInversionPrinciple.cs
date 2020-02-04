
namespace SolidExamples.D
{
    public class ViolationDependencyInversionPrinciple
    {
        //“Programe para uma interface e não para uma implementação.”

        public class MeuContextSql 
        {
           public void myConnection()
            {

            }
        }

        public class PasswordReminder
        {
            private MeuContextSql dbConnection;

            public PasswordReminder()
            {       
                //responsavel por criar instancia = forte acoplamento
                this.dbConnection = new MeuContextSql();
            }

            // Faz alguma coisa
        }
    }
}
