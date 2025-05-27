using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using reservepp;
using System.Collections.Generic;
using System.Linq;

namespace reservepp.Tests
{
    [TestClass]
    public class TCKEmployeeActionsTests
    {
        [TestMethod]
        public void AgreeOffer_True_NoAvailableConscripts_UpdatesOrderWithNoConscripts()
        {
            // Arrange
            var order = new Order { OrderID = 1, DocID = 99, OrderNum = 3, Status = "Не переглянуто" };

            var mockOrderService = new Mock<IOrderService>();
            mockOrderService.Setup(s => s.GetAllOrders()).Returns(new List<Order> { order });

            var mockUserService = new Mock<IUserService>();
            mockUserService.Setup(s => s.GetUsersByRole("Conscript"))
                           .Returns(new List<UserDto>()); // жодного придатного

            var actions = new TCKEmployeeActions(mockOrderService.Object, mockUserService.Object);

            // Act
            string result = actions.AgreeOffer(true);

            // Assert
            Assert.AreEqual($"⚠️ OrderID {order.OrderID} → Прийнято, але призовників немає.", result);
            Assert.AreEqual("Прийнято, але призовників немає.", order.Status);

            mockOrderService.Verify(s => s.UpdateOrder(order), Times.Once);
            mockUserService.Verify(s => s.UpdateUser(It.IsAny<UserDto>()), Times.Never);
        }
        [TestMethod]
        public void AgreeOffer_True_WithAvailableConscripts_UpdatesUsersAndOrder()
        {
            // Arrange
            var order = new Order { OrderID = 2, DocID = 100, OrderNum = 2, Status = "Не переглянуто" };

            var conscripts = new List<UserDto>
            {
                new UserDto { DocID = 1, ArmyUnit = "None" },
                new UserDto { DocID = 2, ArmyUnit = "None" },
                new UserDto { DocID = 3, ArmyUnit = "None" }, // більше ніж потрібно
            };

            var mockOrderService = new Mock<IOrderService>();
            mockOrderService.Setup(s => s.GetAllOrders()).Returns(new List<Order> { order });

            var mockUserService = new Mock<IUserService>();
            mockUserService.Setup(s => s.GetUsersByRole("Conscript")).Returns(conscripts);

            var actions = new TCKEmployeeActions(mockOrderService.Object, mockUserService.Object);

            // Act
            string result = actions.AgreeOffer(true);

            // Assert
            Assert.IsTrue(result.Contains($"OrderID {order.OrderID}"));
            Assert.IsTrue(order.Status.StartsWith("Прийнято ("));

            mockOrderService.Verify(s => s.UpdateOrder(order), Times.Once);
            mockUserService.Verify(s => s.UpdateUser(It.Is<UserDto>(u => u.DocID == 1)), Times.Once);
            mockUserService.Verify(s => s.UpdateUser(It.Is<UserDto>(u => u.DocID == 2)), Times.Once);
            mockUserService.Verify(s => s.UpdateUser(It.Is<UserDto>(u => u.DocID == 3)), Times.Never); // бо OrderNum = 2
        }
        [TestMethod]
        public void AgreeOffer_EmptyOrders_ReturnsEmptyListMessage()
        {
            // Arrange
            var mockOrderService = new Mock<IOrderService>();
            var mockUserService = new Mock<IUserService>();

            mockOrderService.Setup(s => s.GetAllOrders()).Returns(new List<Order>());

            var actions = new TCKEmployeeActions(mockOrderService.Object, mockUserService.Object);

            // Act
            string result = actions.AgreeOffer(true);

            // Assert
            Assert.AreEqual("Список запитів порожній.", result);
            mockOrderService.Verify(s => s.UpdateOrder(It.IsAny<Order>()), Times.Never);
        }
    }
}
