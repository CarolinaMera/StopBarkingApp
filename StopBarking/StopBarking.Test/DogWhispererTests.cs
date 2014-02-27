using NUnit.Framework;
using StopBarking.Model;

namespace StopBarking.Test
{
    [TestFixture]
    public class DogWhispererTests
    {
        [Test]
        public void CanRemoveMotivation_BMPeople_FTM120(){
            var dogBarking = new DogBarking(BarkingMotivation.People);
            var dogWhisperer = new DogWhisperer { FreeTimeInMinutes = 120 };
            Assert.True(dogWhisperer.CanRemoveMotivation(dogBarking.Motivation.Value));
        }


    }
}
