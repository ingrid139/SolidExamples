
namespace SolidExamples.I
{
    public class  InterfaceSegregationPrinciple
    {
        /*Uma classe não deve ser forçada a implementar interfaces 
            e métodos que não irão utilizar.*/

        public interface Aves
        {
            int setLocalizacao(int longitude, int latitude);
        }

        public interface AvesQueVoam : Aves
        {
            int setAltitude(int altitude);
        }

        public class  Papagaio : AvesQueVoam
        {
            public int setLocalizacao(int longitude, int latitude)
            {
                //Faz alguma coisa
                return 0;
            }

            public int setAltitude(int altitude)
            {
                //Faz alguma coisa   
                return 0;
            }
        }

        public class  Pinguim : Aves
        {
            public int setLocalizacao(int longitude, int latitude)
            {
                //Faz alguma coisa
                return 0;
            }

        }
    }
}
