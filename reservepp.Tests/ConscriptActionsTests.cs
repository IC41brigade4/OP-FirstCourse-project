using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using reservepp;

namespace reservepp.Tests
{
    [TestClass]
    public class ConscriptActionsTests
    {
        [TestMethod]
        public void GetMobilizated_ValidOfficer_UpdatesConscriptAndReturnsTrue()
        {
            // Arrange
            var mockUserService = new Mock<IUserService>();
            var officer = new UserDto { DocID = 1, Role = "Officer", ArmyUnit = "UnitA" };
            var conscript = new UserDto { DocID = 2, ArmyUnit = "None" };

            mockUserService.Setup(s => s.GetById(1)).Returns(officer);

            var actions = new ConscriptActions(mockUserService.Object);

            // Act
            var result = actions.GetMobilizated(conscript, 1);

            // Assert
            Assert.AreEqual(true, result);
            Assert.AreEqual("UnitA", conscript.ArmyUnit);
            mockUserService.Verify(s => s.UpdateUser(conscript), Times.Once);
        }
        [TestMethod]
        public void LeaveArmy_Always_ResetsArmyUnitAndReturnsTrue()
        {
            // Arrange
            var mockUserService = new Mock<IUserService>();
            var conscript = new UserDto { DocID = 3, ArmyUnit = "Something" };

            var actions = new ConscriptActions(mockUserService.Object);

            // Act
            var result = actions.LeaveArmy(conscript);

            // Assert
            Assert.AreEqual(true, result);
            Assert.AreEqual("None", conscript.ArmyUnit);
            mockUserService.Verify(s => s.UpdateUser(conscript), Times.Once);
        }

    }
}
