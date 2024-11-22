using CalculatorAPI.Controllers;
using CalculatorAPI.Models;
using Moq;

namespace CalculatorUnitTestProject
{
    public class CalculatorControllerTest
    {
        private CalculatorService _calculatorService;
        public CalculatorControllerTest()
        {
            _calculatorService = new CalculatorService();
        }

        [Fact]
        public void Add()
        {
            //arrange
            int n1 = 5;
            int n2 = 3;
            int expected = 8;

            //act
            var actual=_calculatorService.Add(n1, n2);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Subtract()
        {
            //arrange
            int n1 = 8;
            int n2 = 10;
            int expected = 2;

            //act
            var actual = _calculatorService.Subtract(n1, n2);

            //assert
            Assert.Equal(expected, actual);
        }

        
        [Theory]
        [InlineData(5,3,15)]
        public void Multiply(int a,int b,int c)
        {
            //arrange
            int n1 = a;
            int n2 = b;
            int expected = c;

            //act
            var actual = _calculatorService.Multiply(n1, n2);

            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Divide()
        {
            //arrange
            int n1 = 15;
            int n2 = 3;
            int expected = 5;

            //act
            var actual = _calculatorService.Divide(n1, n2);

            //assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ApiAddTest()
        {
            //arrange 
            //calculater service object   ---mocking
            //n1 and n2
            int n1 = 5, n2 = 3;
            Mock<ICalculatorService> mock_calcservice = new Mock<ICalculatorService>();
            //setup this mock
            mock_calcservice.Setup(x=>x.Add(n1,n2))
                       .Returns(8);

            //act
            var apiController = new CalculatorController(mock_calcservice.Object);
            var actual = apiController.Add(n1, n2);

            //assert
            Assert.Equal(8, actual);

        }
    }
}