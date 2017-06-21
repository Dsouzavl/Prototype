using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype {
    class Program {
        static void Main(string[] args) {
            var response = new MutableResponse();
            response.response = "pagina html";
            response.DisplayResponse();

            var response2 = response.Clone() as MutableResponse;
            response2.DisplayResponse();
            Console.ReadLine();
        }
    }
}
