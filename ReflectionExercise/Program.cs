using System;

namespace ReflectionExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            using(var refle = new UrlReflectionModel())
            {

                Console.WriteLine(refle.ConstructUrlWithModel<Pessoa>(new Pessoa()
                {
                    Nome = "LuizFrancisco",
                    Idade = "25",
                    Rg = "402798302",
                    Telefone = "44134255"
                }));
            }

            Console.Read();
        }
    }
}
