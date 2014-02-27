using System;
using System.Collections.Generic;
using StopBarking.Model;

namespace StopBarking
{
    public class Program
    {
        public static void Main(string[] args){
            var dogBarking = new DogBarking(BarkingMotivation.People);
            var dogWhisperer = new DogWhisperer{FreeTimeInMinutes = 120};
            
            while (dogBarking.Motivation != null )
            {
                Console.WriteLine(dogBarking.Bark());
                dogBarking.Motivation = dogWhisperer.CanRemoveMotivation(dogBarking.Motivation.Value) ? null : dogBarking.Motivation;
            }
            Console.ReadLine();
        }
    }
}