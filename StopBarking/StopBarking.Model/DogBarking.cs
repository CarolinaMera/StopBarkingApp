using System.Collections.Generic;

namespace StopBarking.Model
{
    public enum BarkingMotivation
    {
        People,
        OtherDogs,
        Ghost
    }


    public class DogBarking
    {
        public BarkingMotivation? Motivation { get; set; }

        public DogBarking(BarkingMotivation? motivation){
            Motivation = motivation;
        }

        public List<string> KeepBarking(){
            var response = new List<string>();

            while (Motivation.HasValue){
                response.Add(Bark());
            }
            return response;
        }

        public string Bark(){
            return Motivation.HasValue? "WOOF": "SILENCE";
        }
    }
}