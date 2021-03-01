using System.Collections.Generic;

namespace VirtualMachineCoffee.App.Shared.Domians.Contracts
{
    public interface ICoinService
    {
        List<decimal> GetCoinsReturn(decimal money);
    }
}