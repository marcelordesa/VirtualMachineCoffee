using System.Collections.Generic;
using System.Linq;

namespace VirtualMachineCoffee.App.Shared.Domians.Entities
{
    public class Order
    {
        public Coffee SelectionCoffee { get; private set; }
        public List<decimal> CoinsPay { get; private set; }
        public string MessageError { get; private set; }

        public Order(Coffee selectionCoffee, List<decimal> coinsPay)
        {
            this.SelectionCoffee = selectionCoffee;
            this.CoinsPay = coinsPay;
            this.ValidationFields();
        }

        private void ValidationFields()
        {
            this.MessageError = string.Empty;

            if (this.SelectionCoffee == null)
                this.MessageError = this.MessageError + "Selecione o café do seu gosto\n";

            if (!this.CoinsPay.Any())
                this.MessageError = this.MessageError + "Deposite as moedas para o pagamento\n";
            else 
            {
                var itemsOneCents = this.CoinsPay.Where(c => c == CoinsType.OneCents).ToList();
                if (itemsOneCents.Count > 0)
                {
                    this.MessageError = this.MessageError + "Não é aceito moedas de 1 centavo\n";
                    this.CoinsPay.Remove(CoinsType.OneCents);
                }

                var itemsFiveCents = this.CoinsPay.Where(c => c == CoinsType.FiveCents).ToList();
                if (itemsFiveCents.Count > 0)
                {
                    this.MessageError = this.MessageError + "Não é aceito moedas de 5 centavos\n";
                    this.CoinsPay.Remove(CoinsType.FiveCents);
                }
            }

            if (this.CoinsPay.Sum() < this.SelectionCoffee.ValueCoffee)
                this.MessageError = this.MessageError + "O valor pago está abaixo do valor do produto\n";
        }
    }
}