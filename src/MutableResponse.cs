using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype {
    public class MutableResponse : ICloneable {

        public string response { get; set; }

        public void DisplayResponse() 
        {
            Console.WriteLine(response);
            Console.ReadLine();
        }

        public object Clone() {
            return MemberwiseClone();
        }
    }
}
