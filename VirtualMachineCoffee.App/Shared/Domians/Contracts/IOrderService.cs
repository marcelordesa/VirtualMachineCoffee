using VirtualMachineCoffee.App.Shared.Domians.Entities;

namespace VirtualMachineCoffee.App.Shared.Domians.Contracts
{
    public interface IOrderService
    {
        decimal ConfirmOperation(Order order);
    }
}