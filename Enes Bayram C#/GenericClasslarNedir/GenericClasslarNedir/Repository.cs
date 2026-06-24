using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasslarNedir
{
    public class Repository<T>
    {
        public List<T> getir()
        {
            // Veritabanında ilgili tabloya git ve oradan kayıtları getir.


            return null;
        }

        public string ekle(T data)
        {
            // Veritabanına git ilgili tabloya şu T tipindeki datayı ekle

            return "Data başarılı bir şekilde eklenmiştir.";
        }

        
    }
}
