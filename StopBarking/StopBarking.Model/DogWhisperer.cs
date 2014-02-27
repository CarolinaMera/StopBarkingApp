namespace StopBarking.Model
{
    public class DogWhisperer
    {
        public int FreeTimeInMinutes { get; set; }


        public bool CanRemoveMotivation(BarkingMotivation motivation){
            switch (motivation){
                case BarkingMotivation.People:
                case BarkingMotivation.OtherDogs:
                    return true;
                case BarkingMotivation.Ghost:
                    return false;
            }
            return false;
        }

        public bool CanIgnore(){
            return FreeTimeInMinutes > 240;
        }

        public bool CanTeachQuietCommand(){
            return FreeTimeInMinutes > 120;
        }

        public bool CanKeepDogTired(){
            return FreeTimeInMinutes > 60;
        }

        public bool CanUseUltrasonicDevice(int frequency){
            return frequency >= 46;
        }

    }
}