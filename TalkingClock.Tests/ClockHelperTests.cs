using NUnit.Framework;

namespace TalkingClock.Tests
{
    public class ClockHelperTests
    {

        [Test]
        public void Should_Return_TimeInWords_When_InputTimeInDigitIsProvided()
        {
            string inputTime = "14:10";

            string timeInWord = ClockHelper.ConvertTimeToWord(inputTime);

            Assert.AreEqual("Ten past two", timeInWord);
        }

        [Test]
        public void Should_Return_TimeInWords_When_InputMinuteIsZero()
        {
            string inputTime = "14:00";

            string timeInWord = ClockHelper.ConvertTimeToWord(inputTime);

            Assert.AreEqual("Two o'clock", timeInWord);
        }

        [Test]
        public void Should_Return_TimeInWordsThatContainsQuarterpast_When_InputTimeMinuteIs_15()
        {
            string inputTime = "14:15";

            string timeInWord = ClockHelper.ConvertTimeToWord(inputTime);

            Assert.AreEqual("Quarter past two", timeInWord);
        }

        [Test]
        public void Should_Return_TimeInWordsThatContainsHalfPast_When_InputTimeMinuteIs_30()
        {
            string inputTime = "14:30";

            string timeInWord = ClockHelper.ConvertTimeToWord(inputTime);

            Assert.AreEqual("Half past two", timeInWord);
        }

        [Test]
        public void Should_Return_TimeInWordsThatContainsQuarterto_When_InputTimeMinuteIs_45()
        {
            string inputTime = "14:45";

            string timeInWord = ClockHelper.ConvertTimeToWord(inputTime);

            Assert.AreEqual("Quarter to three", timeInWord);
        }

        [Test]
        public void Should_Return_TimeInWordsThatContainsPast_When_InputTimeMinuteIs_LessThan30()
        {
            string inputTime = "14:29";

            string timeInWord = ClockHelper.ConvertTimeToWord(inputTime);

            Assert.AreEqual("Twenty nine past two", timeInWord);
        }

        [Test]
        public void Should_Return_TimeInWordsThatContainsTo_When_InputTimeMinuteIs_GreaterThan30()
        {
            string inputTime = "14:35";

            string timeInWord = ClockHelper.ConvertTimeToWord(inputTime);

            Assert.AreEqual("Twenty five to three", timeInWord);
        }
    }
}