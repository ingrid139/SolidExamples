using System;
using System.IO;

namespace SolidExamples.L
{
    public class ViolationLiskovSubstitutionPrinciple
    {
        /*se S é um subtipo de T, então os objetos do tipo T, em um programa, 
         * podem ser substituídos pelos objetos de tipo S 
         * sem que seja necessário alterar as propriedades deste programa.*/

        //Sobrescrevendo um método que não faz nada...
        public class Voluntario : ContratoDeTrabalho
        {
            public decimal remuneracao()
            {
                //Voluntario não tem remuneração
                throw new NotImplementedException();
            }
        }
        public class ContratoDeTrabalho
        {

        }


        //Lançando uma exceção inesperada...
        public class MusicPlay
        {
            public void playRecords(FileInfo file)
            {
                // toca a música   
            }
        }

        public class Mp3MusicPlay : MusicPlay
        {
            public void play(FileInfo file)
            {
                if (file.Extension != "mp3")
                {
                    //???
                    throw new Exception();
                }

                // toca a música
            }
        }


        //Retornando valores de tipos diferentes...
        public class Auth
        {
            public bool checkCredentials(string login, string password)
            {
                // faz alguma coisa

                return true;
            }
        }

        public class AuthApi : Auth
        {
        public bool checkCredentials(string login, string password)
            {
                // faz alguma coisa

                return Ok(new
                {
                    success = true,
                    data = 200
                });
            }

            private bool Ok(object p)
            {
                throw new NotImplementedException();
            }
        }
    }
}
