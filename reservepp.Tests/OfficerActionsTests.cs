using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using reservepp;

namespace reservepp.Tests
{
    [TestClass]
    public class OfficerActionsTests
    {
        [TestMethod]
        public void MakeOffer_ValidInput_ReturnsTrueAndCallsAddOrder()
        {
            // Arrange
            var mockOrderService = new Mock<IOrderService>();
            var actions = new OfficerActions(mockOrderService.Object);

            string orderText = "Test order";
            string peopleNumText = "5";
            int docId = 123;

            // Act
            bool result = actions.MakeOffer(orderText, peopleNumText, docId);

            // Assert
            Assert.AreEqual(true, result);
            mockOrderService.Verify(s => s.AddOrder(It.Is<Order>(o =>
                o.DocID == docId &&
                o.OrderNum == 5 &&
                o.OrderText == "Test order" &&
                o.Status == "Не переглянуто"
            )), Times.Once);
        }

        [TestMethod]
        public void MakeOffer_InvalidPeopleNum_ReturnsFalseAndDoesNotCallAddOrder()
        {
            // Arrange
            var mockOrderService = new Mock<IOrderService>();
            var actions = new OfficerActions(mockOrderService.Object);

            string orderText = "Invalid";
            string peopleNumText = "notANumber";
            int docId = 999;

            // Act
            bool result = actions.MakeOffer(orderText, peopleNumText, docId);

            // Assert
            Assert.AreEqual(false, result);
            mockOrderService.Verify(s => s.AddOrder(It.IsAny<Order>()), Times.Never);
        }
    }
}
