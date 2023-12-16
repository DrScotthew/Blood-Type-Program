//Blood Type Project
//This program will determine which blood types the user can donate to and receive from based on the blood type they enter.  
//Will also take in input for user's parents and determine potential blood types for user to have.

using System;
using System.Collections.Generic;
using System.Linq;

namespace BloodTypeProject_console_
{
    class Program
    {
        static void Main(string[] args)
        {   List<string> positiveBlood = new List<string>() { "O+", "A+", "B+", "AB+" };   //only positive blood types...
            List<string> negativeBlood = new List<string>() { "O-", "A-", "B-", "AB-" };   //only negative blood types...
            Console.WriteLine("Hello, please enter your blood type in the format 'XX+' or 'XX-'." +
                "\n For example, if your blood type is O positive, please type in 'O+'.");
            string userInput = Console.ReadLine();
            bool isPositive = false;
            bool isNegative = false;

            if (positiveBlood.Contains(userInput))
            {
                isPositive = true;  //checks if positive...
                Console.WriteLine("Positive blood type");
            }
            else if (negativeBlood.Contains(userInput))
            {
                isNegative = true;  //checks if negative...
                Console.WriteLine("Negative blood type");
            }
            else
            {
                Console.WriteLine("Invalid blood type...");
            }

            Console.WriteLine("Your blood type is: " + userInput);
            Console.WriteLine("You can donate to the following types: ");

            //following statements will check for specific blood type and output potential recipients...
            if(isPositive && userInput.StartsWith("O"))
            {   //O+ allows for all positive blood types...prints out positive blood type list with no additional operations...
                positiveBlood.ForEach(Console.WriteLine);

                Console.WriteLine("You can receive blood from the following types: ");  //prints out what donors user can receive blood from...
                foreach (var s in positiveBlood)
                {
                    if (s.StartsWith("O"))  //checks to see if elements in blood type list start with user input...
                    {
                        Console.WriteLine(s);   //prints out only blood types in list that start with user input of 'A' here...
                    }
                }
                foreach(var s in negativeBlood)
                {
                    if (s.StartsWith("O"))
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            else if(isPositive && userInput.StartsWith("A") && userInput!=("AB+") && userInput!=("AB-"))
            {   //A+ allows for A+, AB+...sorts through positive list and pulls out any instances with 'A' attached along with the 'O'...

                foreach (var s in positiveBlood)
                {
                    if (s.StartsWith("A"))  //checks to see if elements in blood type list start with user input...
                    {
                        Console.WriteLine(s);   //prints out only blood types in list that start with user input of 'A' here...
                    }
                }
                Console.WriteLine("You can receive blood from the following types: ");
                foreach (var s in positiveBlood)
                {
                    if ((s.StartsWith("A") && s!=("AB+")) || s.StartsWith("O"))  //checks to see if elements in blood type list start with user input...
                    {
                        Console.WriteLine(s);   //prints out only blood types in list that start with user input of 'A' here...
                    }
                }
                foreach (var s in negativeBlood)
                {
                    if (s.StartsWith("A") && s!=("AB-") || s.StartsWith("O"))  //checks to see if elements in blood type list start with user input...
                    {
                        Console.WriteLine(s);   //prints out only blood types in list that start with user input of 'A' here...
                    }
                }
            }
            else if(isPositive && userInput.StartsWith("B"))
            {
                foreach (var s in positiveBlood)
                {
                    if ((s.Contains("B") && s != ("AB+")) || s.StartsWith("O"))
                    {
                        Console.WriteLine(s); 
                    }
                }
                foreach (var s in negativeBlood)
                {
                    if (s.StartsWith("B") && s != ("AB-") || s.StartsWith("O"))
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            else if(isPositive && userInput.StartsWith("AB"))
            {   //AB+ allows for only AB positive types...
                foreach (var s in positiveBlood)
                {
                    if (s.StartsWith("AB"))
                    {
                        Console.WriteLine(s);
                    }
                }
                Console.WriteLine("You can receive blood from the following types: ");
                positiveBlood.ForEach(Console.WriteLine);
                negativeBlood.ForEach(Console.WriteLine);
            }
            else if(isNegative && userInput.Contains("O"))
            {   //O- allows for all blood types...prints out both lists with no additional operations...
                positiveBlood.ForEach(Console.WriteLine);
                negativeBlood.ForEach(Console.WriteLine);
                Console.WriteLine("You can receive blood from the following types: ");
                Console.WriteLine("O-");    //simple coded in version for O- donors...
                
            }
            else if(isNegative && userInput.StartsWith("A") && userInput!=("AB-"))
            {
                foreach (var s in negativeBlood)
                {
                    if (s.StartsWith("AB"))
                    {
                        Console.WriteLine(s);
                    }
                }
                foreach (var s in positiveBlood)
                {
                    if (s.StartsWith("AB"))
                    {
                        Console.WriteLine(s);
                    }
                }
                Console.WriteLine("You can receive blood from the following types: ");
                foreach (var s in negativeBlood)
                {
                    if (s.StartsWith("A"))
                    {
                        Console.WriteLine(s);
                    }
                }
                foreach (var s in negativeBlood)
                {
                    if (s.StartsWith("O"))
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            else if(isNegative && userInput.StartsWith("B"))
            {
                foreach (var s in negativeBlood)
                {
                    if (s.StartsWith("B"))
                    {
                        Console.WriteLine(s);
                    }
                }
                foreach (var s in positiveBlood)
                {
                    if (s.StartsWith("B")) 
                    {
                        Console.WriteLine(s);  
                    }
                }
                foreach (var s in negativeBlood)
                {
                    if (s.StartsWith("AB"))
                    {
                        Console.WriteLine(s); 
                    }
                }
                foreach (var s in positiveBlood)
                {
                    if (s.StartsWith("AB"))  
                    {
                        Console.WriteLine(s);   
                    }
                }
                Console.WriteLine("You can receive blood from the following types: ");
                foreach (var s in negativeBlood)
                {
                    if (s.StartsWith("B"))
                    {
                        Console.WriteLine(s);
                    }
                }
                foreach (var s in negativeBlood)
                {
                    if (s.StartsWith("O"))
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            else if(isNegative && userInput.StartsWith("AB"))
            {
                foreach (var s in negativeBlood)
                {
                    if (s.Contains("B"))
                    {
                        Console.WriteLine(s); 
                    }
                }
                foreach (var s in positiveBlood)
                {
                    if (s.StartsWith("AB")) 
                    {
                        Console.WriteLine(s); 
                    }
                }
                Console.WriteLine("You can receive blood from the following types: ");
                negativeBlood.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("Error...");
            }

            //Program will now ask for user's parents' blood types and determine potential blood types of user...
            Console.WriteLine("What is the blood type of your mother?  Don't include positive or negative...");
            string motherBloodType = Console.ReadLine();
            Console.WriteLine("What is the blood type of your father?  Don't include positive or negative...");
            string fatherBloodType = Console.ReadLine();

            List<string> allBloodTypes = new List<string>() { "O", "A", "B", "AB" };    //list of all blood types regardless of positive or negative...
            Console.WriteLine("Your possible blood types could be: ");
            if (motherBloodType==("A") && fatherBloodType==("A"))
            {
                Console.WriteLine("A");
                Console.WriteLine("O");
            }
            else if (motherBloodType==("A") && fatherBloodType == ("B"))
            {
                Console.WriteLine("AB");
                Console.WriteLine("O");
                Console.WriteLine("A");
                Console.WriteLine("B");
            }
            else if (motherBloodType==("A")&& fatherBloodType==("O"))
            {
                Console.WriteLine("A");
                Console.WriteLine("O");
            }
            else if (motherBloodType==("B")&& fatherBloodType == ("B"))
            {
                Console.WriteLine("B");
                Console.WriteLine("O");
            }
            else if (motherBloodType==("B")&& fatherBloodType == ("O"))
            {
                Console.WriteLine("B");
                Console.WriteLine("O");
            }
            else if (motherBloodType==("AB")&& fatherBloodType == ("A"))
            {
                Console.WriteLine("AB");
                Console.WriteLine("B");
                Console.WriteLine("A");
            }
            else if (motherBloodType==("AB")&& fatherBloodType == ("AB"))
            {
                Console.WriteLine("AB");
                Console.WriteLine("A");
                Console.WriteLine("B");
            }
            else if (motherBloodType==("AB")&& fatherBloodType == ("O"))
            {
                Console.WriteLine("A");
                Console.WriteLine("B");
            }
            else if (motherBloodType==("O")&& fatherBloodType == ("O"))
            {
                Console.WriteLine("O");
            }
            else
            {
                Console.WriteLine("Error...Invalid inputs...");
            }
        }
    }
}
