using System;
using System.Collections.Generic;
using System.Linq;

namespace JMBackend
{
    public class Acciones
    {



        public List<int> RandomizarLista(List<int> numeros)
        {

           return numeros.OrderBy(x => Guid.NewGuid()).ToList();

        }



    }
}
