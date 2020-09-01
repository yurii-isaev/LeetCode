using Leetcode.MeetingRooms;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class MeetingRoomsTests
    {
        private readonly int[][] _intervals2 =
        {
            new[] {7, 10}
        };

        private readonly int[][] _intervals3 =
        {
            new[] {0, 30}, new[] {5, 10}, new[] {15, 20}
        };

        private readonly int[][] _intervals6 =
        {
            new[] {0, 30}, new[] {5, 10}, new[] {15, 20}, new[] {1, 5}, new[] {5, 20}, new[] {15, 40}
        };

        [Test]
        public void CanAttendMeetings_BasicTests()
        {
            Assert.AreEqual(true, Solution.CanAttendMeetings1(_intervals2));
            Assert.AreEqual(false, Solution.CanAttendMeetings1(_intervals3));
            Assert.AreEqual(false, Solution.CanAttendMeetings1(_intervals6));
        }

        [Test]
        public void MinMeetingRooms_BasicTests()
        {
            Assert.AreEqual(1, Solution.CanAttendMeetings2(_intervals2));
            Assert.AreEqual(2, Solution.CanAttendMeetings2(_intervals3));
            Assert.AreEqual(4, Solution.CanAttendMeetings2(_intervals6));
        }
    }
}
