﻿using System;
using System.Collections.Generic;

// Every class in the program is defined within the "Quest" namespace
// Classes within the same namespace refer to one another without a "using" statement
namespace Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a few challenges for our Adventurer's quest
            // The "Challenge" Constructor takes three arguments
            //   the text of the challenge
            //   a correct answer
            //   a number of awesome points to gain or lose depending on the success of the challenge
            Challenge twoPlusTwo = new Challenge("2 + 2?", 4, 10);
            Challenge theAnswer = new Challenge(
                "What's the answer to life, the universe and everything?", 42, 25);
            Challenge whatSecond = new Challenge(
                "What is the current second?", DateTime.Now.Second, 50);

            int randomNumber = new Random().Next() % 10;
            Challenge guessRandom = new Challenge("What number am I thinking of?", randomNumber, 25);

            Challenge favoriteBeatle = new Challenge(
                @"Who's your favorite Beatle?
    1) John
    2) Paul
    3) George
    4) Ringo
",
                4, 20
            );

            // "Awesomeness" is like our Adventurer's current "score"
            // A higher Awesomeness is better

            //Make a true valued bool for looping purposes.
            bool keepPlaying = true;

            // Here we set some reasonable min and max values.
            //  If an Adventurer has an Awesomeness greater than the max, they are truly awesome
            //  If an Adventurer has an Awesomeness less than the min, they are terrible
            int minAwesomeness = 0;
            int maxAwesomeness = 100;

            // Make a new "Adventurer" object using the "Adventurer" class
            //Needs an input field so the user can input whatever name they like.
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
                //Also need to intialize a robe object to assign to our wizard.
            Robe robe = new Robe();
                //Colors
            List<string> robeColors = new List<string>();
            robeColors.Add("Green");
            robeColors.Add("Red");
            robeColors.Add("White");
            robe.Colors = robeColors;
                //Assign a length (in inches) to the robe.
            robe.Length = 116;

            Adventurer theAdventurer = new Adventurer(userName, robe);

            //Describe the adventurer to the player.
            Console.WriteLine(theAdventurer.GetDescription());

            // A list of challenges for the Adventurer to complete
            // Note we can use the List class here because have the line "using System.Collections.Generic;" at the top of the file.
            List<Challenge> challenges = new List<Challenge>()
            {
                twoPlusTwo,
                theAnswer,
                whatSecond,
                guessRandom,
                favoriteBeatle
            };

            // Loop through all the challenges and subject the Adventurer to them
            while (keepPlaying)
            {
                foreach (Challenge challenge in challenges)
                {
                    challenge.RunChallenge(theAdventurer);
                }
                Console.WriteLine("Would you like to play again? Y/N");
                if(Console.ReadLine().ToLower() == ("y")){
                    keepPlaying = true;
                }
                else{
                    //should break the loop.
                    break;
                }
            }

            // This code examines how Awesome the Adventurer is after completing the challenges
            // And praises or humiliates them accordingly
            if (theAdventurer.Awesomeness >= maxAwesomeness)
            {
                Console.WriteLine("YOU DID IT! You are truly awesome!");
            }
            else if (theAdventurer.Awesomeness <= minAwesomeness)
            {
                Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
            }
            else
            {
                Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
            }
        }
    }
}