
namespace SolidExamples.D
{
    public class DependencyInversionPrinciple
    {
        //Princípio da Inversão de Dependência — Dependa de abstrações e não de implementações.
        /*Tio Bob
            1. Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender da abstração.
            2. Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações.
            */

        public interface DBConnectionInterface
        {
            void connect();
        }


        public class MySQLConnection : DBConnectionInterface
        {
            public void connect()
            {
                // ...
            }
        }

        public class OracleConnection : DBConnectionInterface
        {
            public void connect()
            {
                // ...
            }
        }

        public class PasswordReminder
        {
            private readonly DBConnectionInterface _dbConnection;

            public PasswordReminder(DBConnectionInterface dbConnection)
            {
                _dbConnection = dbConnection;
            }

            // Faz alguma coisa
        }

    }
}
