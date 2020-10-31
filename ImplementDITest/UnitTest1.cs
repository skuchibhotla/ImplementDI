using ImplementDI.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ImplementDITest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetsDesiredOutput()
        {
            // Arrange

            // Act
            Customer customerObj = new Customer();
            customerObj.CreateCustomer();

            // Assert
        }
    }
}
