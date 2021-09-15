using System;
using System.Collections.Generic;

namespace Tamagotchi2
{
    public class Tamagotchi
    {
        int hunger = 0;
        int boredom = 0;
        List<string> words = new List<string>()
        {
            "Hello",
            "Korv",
            "Shit >:-)"
        };
        bool isAlive = true;
        Random generator = new Random();
        //int r = generator.Next();
        public string name = "";


        public void Feed()
        {
            hunger--;
        }

        public void Hi()
        {
            int r = generator.Next(0, words.Count);
            System.Console.WriteLine(name + " says " + words[r]);
            ReduceBoredom();

        }

        public void Teach(string word)
        {
            // System.Console.WriteLine("What new word do you want " + name + " to know?");
            // string svar = Console.ReadLine();
            words.Add(word);
            ReduceBoredom();
        }

        public void Tick()
        {
            hunger++;
            boredom++;

            if (hunger == 10 || hunger >= 10)
            {
                isAlive = false;
            }

            if (boredom == 10 || boredom >= 10)
            {
                isAlive = false;
            }

        }

        public void PrintStats()
        {
            System.Console.WriteLine("Hunger: " + hunger);
            System.Console.WriteLine("Boredom: " + boredom);
            if (isAlive == true)
            {
                System.Console.WriteLine(name + " lever fortfarande!");
            }
            else
            {
                System.Console.WriteLine(name + " är död :-(");
            }
        }

        public bool GetAlive()
        {
            return isAlive;
        }

        private void ReduceBoredom()
        {
            boredom--;
        }


    }
}