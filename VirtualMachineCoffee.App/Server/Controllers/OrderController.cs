using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using VirtualMachineCoffee.App.Shared.Domians.Contracts;
using VirtualMachineCoffee.App.Shared.Domians.Entities;

namespace VirtualMachineCoffee.App.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;
        private readonly ICoinService coinService;

        public OrderController(IOrderService _orderService, ICoinService _coinService)
        {
            this.orderService = _orderService;
            this.coinService = _coinService;
        }

        [HttpPost]
        public IActionResult PostConfirmOperation(Order order)
        {
            try
            {
                var returnCoin = this.orderService.ConfirmOperation(order);
                return Ok(this.coinService.GetCoinsReturn(returnCoin));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao confirmar pedido.");
            }
        }
    }
}