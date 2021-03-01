using System.Collections.Generic;
using VirtualMachineCoffee.App.Shared.Domians.Contracts;
using VirtualMachineCoffee.App.Shared.Domians.Entities;

namespace VirtualMachineCoffee.App.Shared.ServiceDomains
{
    public class CoinService : ICoinService
    {
        private List<decimal> coinsReturn = new List<decimal>();
        public List<decimal> GetCoinsReturn(decimal money)
        {
            decimal difference = money;

            if (difference >= CoinsType.OneReals)
            {
                coinsReturn.Add(CoinsType.OneReals);
                difference = difference - CoinsType.OneReals;
            }

            if (difference >= CoinsType.FiftyCents)
            {
                coinsReturn.Add(CoinsType.FiftyCents);
                difference = difference - CoinsType.FiftyCents;
            }

            if (difference >= CoinsType.TwentyFiveCents)
            {
                coinsReturn.Add(CoinsType.TwentyFiveCents);
                difference = difference - CoinsType.TwentyFiveCents;
            }

            if (difference >= CoinsType.TenCents)
            {
                coinsReturn.Add(CoinsType.TenCents);
                difference = difference - CoinsType.TenCents;
            }

            if (difference > 0)
                GetCoinsReturn(difference);

            return coinsReturn;
        }
    }
}