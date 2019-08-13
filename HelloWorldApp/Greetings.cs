using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    //This class has three properties
    //    From of Person type
    //    To of Person type
    //    Message of string type
    
    class Greetings
    {
        public Person From { get; set; }
        public Person To { get; set; }
        public string Message { get; set; }

        public Greetings() { }

        public override string ToString()//ToString() returns object type as string type
        {
            //return (Message, To.Name, ......Regards , From.Name);
            //return (Message);
            //return string.Format(Message, To.Name, From.Name);

            return Message +" "+ To.Name + "!....Regards " + From.Name ;

           
        }
    }
}
