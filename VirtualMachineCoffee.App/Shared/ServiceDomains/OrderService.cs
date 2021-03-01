using System.Linq;
using VirtualMachineCoffee.App.Shared.Domians.Contracts;
using VirtualMachineCoffee.App.Shared.Domians.Entities;

namespace VirtualMachineCoffee.App.Shared.ServiceDomains
{
    public class OrderService : IOrderService
    {
        public decimal ConfirmOperation(Order order)
        {
            return order.CoinsPay.Sum() - order.SelectionCoffee.ValueCoffee;
        }
    }
}