using CalculatorAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private ICalculatorService _calcservice;

        public CalculatorController(ICalculatorService calculatorService)
        {
            this._calcservice = calculatorService;
        }

        [HttpPost]
        [Route("Add")]
        public int Add(int n1,int n2)
        {
            return _calcservice.Add(n1, n2);
        }

        [HttpPost]
        [Route("Subtract")]
        public int Subtract(int n1, int n2)
        {
            return _calcservice.Subtract(n1, n2);
        }

        [HttpPost]
        [Route("Multiply")]
        public int Multiply(int n1, int n2)
        {
            return _calcservice.Multiply(n1, n2);
        }

        [HttpPost]
        [Route("Divide")]
        public int Divide(int n1, int n2)
        {
            return _calcservice.Divide(n1, n2);
        }
    }


}
