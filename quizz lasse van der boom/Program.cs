using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizz_lasse_van_der_boom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;

            while (true)
            {
                Console.WriteLine("welcome to my quizz about Lasse");
                Console.WriteLine("what is my favortie food you can choose between pizza sushi and cheese  ");
                Console.WriteLine("Enter your anwser:");
                answer = Console.ReadLine();
                if (answer == "pizza" || answer == "sushi" || answer == "cheese")
                {
                    break;
                }
            }

            Console.WriteLine("Your anwser is: " + answer);
            Console.WriteLine("the corect anwser is pizza ");

            if (answer == "sushi")
            {
                Console.WriteLine("you got it wrong the next question is where do i live you can choose between veldhoven rosmalen and veghel  ");
            }

            if (answer == "cheese")
            {
                Console.WriteLine("you got it wrong the next question is where do i live you can choose between veldhoven rosmalen and veghel  ");
            }

            if (answer == "pizza")
            {
                Console.WriteLine("you got it right the next question is where do i live you can choose between vedlhoven rosmalen en veghel");
            }
            while (true)
            {


                Console.WriteLine("typ a answer");
                answer = Console.ReadLine();
                if (answer == "veldhoven" || answer == "rosmalen" || answer == "veghel")
                {
                    break;
                }
            }

            

            Console.WriteLine("your anwser is: " + answer);
            Console.WriteLine("the corect anwser is rosmalen");

            if (answer == "veldhoven")
            {
                Console.WriteLine("you got it wrong the next question is where do i live you can choose between veldhoven rosmalen and veghel  ");
            }

            if (answer == "veghel")
            {
                Console.WriteLine("you got it wrong the next question is how many games did i play you can choose between 70 180 or 270  ");
            }

            if (answer == "rosmalen")
            {
                Console.WriteLine("you got it right the next question is how many games did i play you can choose between 70 180 or 270 ");
            }

            while (true)
            {


                Console.WriteLine("typ a answer");
                answer = Console.ReadLine();
                if (answer == "270" || answer == "70" || answer == "180")
                {
                    break;
                }
            }

            
            Console.WriteLine("your anwser is:" + answer);
            Console.WriteLine("the corect anwser is 270");
            
            if (answer == "70")
            {
                Console.WriteLine("you got it wrong the next question is what is my favorite game you can choose between peak pokemon sun and moon devil may cry  ");
            }
            
            if (answer == "270")
            {
                Console.WriteLine("you got it right the next question is what is my favorite game you can choose between peak pokemon sun and moon devil may cry ");
            }

            if (answer == "180")
            {
                Console.WriteLine("you got it wrong the next question is what is my favorite game you can choose between peak pokemon sun and moon devil may cry ");
            }


            while (true)
            {


                Console.WriteLine("typ a answer");
                answer = Console.ReadLine();
                if (answer == "peak" || answer == "pokemon sun and moon" || answer == "devil may cry")
                {
                    break;
                }
            }
            Console.WriteLine("your anwser is:" + answer);
            
            
            Console.WriteLine(" the corect anwser is pokemon sun and moon ");
            if (answer == "peak")
            {
                Console.WriteLine("you got it wrong the next question is goaing to be what is my favorite movie you can choose between spiderman  shrek deapool ");

            }
            if (answer == "pokemon sun and moon")
            {
                Console.WriteLine("you got it right the next question is goaing to be what is my favorite movie you can choose between spiderman  shrek deapool ");
            }

            if (answer == "devil may cry")
            {
                Console.WriteLine("you got it wrong the next question is goaing to be  what is my favorite movie you can choose between spiderman  shrek deapool ");
            }

            while (true)
            {


                Console.WriteLine("typ a answer");
                answer = Console.ReadLine();
                if (answer == "shrek" || answer == "spiderman" || answer == "deadpool")
                {
                    break;
                }
            }
            

            
            Console.WriteLine("Your anwser is: " + answer);

            Console.WriteLine(" the corect anwser is deadpool ");
            if (answer == "spiderman")
            {
                Console.WriteLine("you got it wrong this was the end of my quizz thanks for playing ");
            }
            if (answer == "shrek")
            {
                Console.WriteLine("you got it wrong this was the end of my quizz thanks for playing ");
            }
            if (answer == "deadpool")
            {
                Console.WriteLine("you got the right answers this is the end of the quizz thanks for playing ");
            }






        }
    }
}
