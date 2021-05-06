using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {







            List<Person> personList = new List<Person>();//list of type Person containing names

            personList.Add(new Person("Alice"));
            personList.Add(new Person("Bob"));
            personList.Add(new Person("Charlie"));

            List<string> messageList = new List<string> { "Hello", "Hola", "Hey" ,"Sawubona"};//list of type string containing messages

            List<Greetings> greetingList = new List<Greetings>();//list of type Greetings which stores greetings created using messageList & personList

            var greetFrom = new Person("Joe"); //greetings send have same value for From
           
            var newGreet = new Greetings();
            newGreet.From = greetFrom;
            int maxMessageCount = 100;// Maximum allowed greetings to send
            int messageCount = 0;
            ConsoleKeyInfo input;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            do
            {
                messageCount++;
                var random = new Random();

                int toIndex = random.Next(personList.Count);//to fetch random person to assign to member To
                newGreet.To = personList[toIndex];

                int messageIndex = random.Next(messageList.Count);//to fetch random message
                newGreet.Message = messageList[messageIndex];

                greetingList.Add(newGreet);

                Console.WriteLine(newGreet.ToString());
                input = Console.ReadKey(true);//Readkey() makes the program wait for a key press , bool value true hides the pressed key

            } while (input.Key != ConsoleKey.Escape && messageCount !=maxMessageCount);//to check exit condition

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;// to calculate time elapsed between creating greetings

            //Console.WriteLine("Total iterations: " + messageCount+ "\n Total time taken: "+ ts.Seconds.ToString());
            Console.WriteLine("Total iterations: " + messageCount + "\n Total time taken: " + ts.Milliseconds.ToString()+ " milliseconds");


        }
    }
}
