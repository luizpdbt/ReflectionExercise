using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ReflectionExercise
{
    public class UrlReflectionModel:IDisposable
    {
        public string ConstructUrlWithModel<T>(T obj)
        {
            var url = string.Empty;
            int contador = 0;
            var refle = obj.GetType();
            var properties = refle.GetProperties();

            foreach(var item in properties)
            {
                if(contador==0)
                {
                    url += $"?{item.Name}={item.GetValue(obj)}";
                }
                url += $"&{item.Name}={item.GetValue(obj)}";
                contador++;
            }

            return url;
        }

        public void Dispose(){}
    }
}
