using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {
           
            while (true)
            {

                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        return;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();
            PrintCapacityCountListDetails(theList);
             

            bool loopexit = true;
            Console.WriteLine("\nDo you want to add "
                    + "\n+NAME  Add to List"
                    + "\n-NAME  Remove from List"
                    + "\nq or Q  to exit");
            do
            {
                
                string input = Console.ReadLine();
                char nav = input[0];
                string value = input.Substring(1).Replace("\"",string.Empty);

                switch(nav)
                {
                    case '+':
                       if ( String.IsNullOrEmpty(value))
	                   {
                            Console.WriteLine("input value should not be null or empty");
                       }
	                   else 
                       {
                            theList.Add(value);
                            PrintCapacityCountListDetails(theList);
                       }
                                            
                       break;
                    case '-':
                        //check if value exists:

                        if(theList.Contains(value))
                        {
                            theList.Remove(value);
                            PrintCapacityCountListDetails(theList);
                            break;
                        }
                        else
                            Console.WriteLine("enter valid name from the list to remove");
                            break;
                    case 'q':
                    case 'Q':    
                        loopexit=false;
                        break;
                    default:
                        Console.WriteLine("Invaid Input...Please enter either + to add the list or - to remove from list");
                        break;
                }
            }while(loopexit);


            //////////////////////////////////////////////////////////////////////////////////////////////

            //1.​​In your words, how does the stack and the heap work in terms of structurallystoring data? You are welcome to use examples or draw to explain their basicstructures.

            //2.​​What are are ​Value Types ​and ​Reference Types, ​and how do they differ?3.Following methods return different answers (see fig below). The first methodreturns

            //3, the second returns
            
            //4. Why? ​MyInt ​is the same class that is declared inexample 2 above

            ///////////////////////////////////////////////////////////////////////////////////////////

            //2.When does the capacity of the list increase? (In other words the size of theunderlying array)?
            //A: If Count exceeds Capacity while adding elements, the capacity is increased by automatically 
            //   reallocating the internal array before copying the old elements and adding the new elements.

            //3.​​How much does the capacity increase?
            // it depends on the number of new elements added to the list.usually twice the size of the existing one.


            //4.​​Why does the capacity not increase at the same pace as elements are added?
            //when elements are added more than the capacity, it Creates a new array, twice the size of the old one.
            //Copies each entry from the old array to the new one,
            //Sets the "last" entry in the new array to the new value, and moves the "last" indicator on by one.



            //5.​​Does the capacity decrease when elements are removed from the list?
            //A: No the Capavity will not be decreased for the list even if elements were removed from the list

            //6.When is it preferable to use an ​array​ you declare yourself instead of a list?
            //A: when we know exact size of the elements coming it is better to use array instead of list.
                                                                                                                                                                                                                                                                                         6.​​When is it preferable to use an ​array​ you declare yourself instead of a list?

        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }


        static void PrintCapacityCountListDetails(List<string> theList)
        {
            // Printing the Capacity of thelist 
            Console.WriteLine("List is having Capacity Is: " + theList.Capacity); 
  
            // Printing the Count of thelist 
            Console.WriteLine("List is having Count Is: " + theList.Count); 

            Console.WriteLine("\nLIST DETAILS" );
            if (theList.Count==0)
	                {  Console.WriteLine("List is Empty"); }
                else
                {  foreach (var item in theList)
	                {
               
                            {Console.WriteLine(item);}

	                }
                    Console.WriteLine(); 
                }
               
        }
    }
}
