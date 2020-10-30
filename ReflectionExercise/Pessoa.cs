using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace ReflectionExercise
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }


        public static string MontaUrlComModelo()
        {
            var url = string.Empty;
            var type = typeof(Pessoa);
            var propertis = type.GetProperties();

            foreach(var p in propertis)
            {
                url += p.Name;
            }

            return "";
        }

    }
}
