using Dojo_Time___Bowling;
using NUnit.Framework;

namespace Dojo_Time___Bowling_Tests
{
    [TestFixture]
    public class BowlingTests
    {
        [Test]
        public void WhenRollIsCalled_ThenTheScoreShouldBeAsExpected()
        {
            var game = new Game();
            game.Roll(5);

            Assert.That(game.Score(), Is.EqualTo(5));
        }

        [Test]
        public void WhenRollIsCalledWithTen_ThenTheScoreShouldBeAsExpected()
        {
            var game = new Game();
            game.Roll(10);

            Assert.That(game.Score(), Is.EqualTo(0));
        }

        [TestCase(20, new[] {10, 5}, TestName = "Strike + One Roll")]
        [TestCase(20, new[] {4, 6, 5}, TestName = "Spare + One Roll")]
        [TestCase(24, new [] {5,5,5,4}, TestName = "Spare + Two Rolls")]
        [TestCase(42, new[] { 10, 5, 5, 5, 2 }, TestName = "Strike + Spare + Two Rolls")]
        public void WhenMultipleRollsAreMade_ThenTheScoreShouldBeAsExpected(int expectedResult, int[] rolls)
        {
            var game = new Game();
            foreach (var roll in rolls)
            {
                game.Roll(roll);
            }

            Assert.That(game.Score(), Is.EqualTo(expectedResult));
        }

        
    }
}
