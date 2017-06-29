using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////string firstName = "Adam";
            ////int lengthOfName = firstName.Length;
            ////    Console.WriteLine(lengthOfName);

            //string myFaveQuote = "\"It's a yam sham\" - Buffy Summers";
            //Console.WriteLine(myFaveQuote);

            //string escapeString = "I want a tab after this line \t I want a new line without WriteLine \n Hi";
            //string escapeString2 = "I want to show a backslash here \\ Hey what's that noise? \a";
            //Console.WriteLine(escapeString);
            //Console.WriteLine(escapeString2);

            //Console.WriteLine("User One, please type something");
            //string userOneInput = Console.ReadLine();
            //Console.WriteLine("User Two, please type something");
            //string userTwoInput = Console.ReadLine();

            //if (userOneInput == userTwoInput)
            //{
            //    Console.WriteLine("User 2 is a copy cat!");
            //}
            //else
            //{
            //    Console.WriteLine("Way to be original!");
            //}


            //Console.WriteLine("User One, please type something");
            //string userOneInput = Console.ReadLine();
            //Console.WriteLine("User Two, please type something");
            //string userTwoInput = Console.ReadLine();

            //if (userOneInput.Equals(userTwoInput))
            //{
            //    Console.WriteLine("User 2 is a copy cat!");
            //}
            //else
            //{
            //    Console.WriteLine("Way to be original!");
            //}

            //string startOfSentence = "My best friend's name is ";
            //string endOfSentence = "Jenny.";

            //Console.WriteLine(startOfSentence + endOfSentence);


            ////these print the same things.
            //Console.WriteLine("My friend " + endOfSentence + " has a cute kid.");
            //Console.WriteLine("My friend {0} has a cute kid.", endOfSentence);


            //Console.WriteLine("This is a tab. \t \nThis is a backslash \\. \nAnd this is a bell sound \a.");



            //string firstName = "Adam";
            //string lastName = "King";

            //    int lengthOfFirstName = firstName.Length;
            //   Console.WriteLine(lengthOfFirstName);

            //int lengthOfLastName = lastName.Length;
            //Console.WriteLine(lengthOfLastName);

            //if (lengthOfFirstName > lengthOfLastName)
            //{
            //    Console.WriteLine("First is longer!");
            //        }
            //else if (lengthOfFirstName == lengthOfLastName)
            //{
            //    Console.WriteLine("Samsis!");
            //}

            //else
            //{
            //    Console.WriteLine("Last must be longer!");
            //        }

            //Console.WriteLine("Please type your first name");
            //string userFirstName = Console.ReadLine();
            //Console.WriteLine("Please type your last name");
            //string userLastName = Console.ReadLine();
            
            //int lengthOfFirstName = userFirstName.Length;
            //Console.WriteLine(lengthOfFirstName);

            //int lengthOfLastName = userLastName.Length;
            //Console.WriteLine(lengthOfLastName);

            //if (lengthOfFirstName > lengthOfLastName)
            //{
            //    Console.WriteLine("First is longer!");
            //}
            //else if (lengthOfFirstName == lengthOfLastName)
            //{
            //    Console.WriteLine("Samsis!");
            //}

            //else
            //{
            //    Console.WriteLine("Last must be longer!");
            //}


            Console.WriteLine("User 1, please type your first name");
            string user1Name = Console.ReadLine();
            Console.WriteLine("User 2, please type your first name");
            string user2Name = Console.ReadLine();

            string lengthOfUser1Name = user1Name;
            Console.WriteLine(lengthOfUser1Name);

            string lengthOfUser2Name = user2Name;
            Console.WriteLine(lengthOfUser2Name);

            if (lengthOfUser1Name == lengthOfUser2Name)
            {
                Console.WriteLine("These Names Are The Same!");
            }

            else
            {
                Console.WriteLine("These Names Are Different!");
            }
        

        }
    }
}
