namespace VirtualMachineCoffee.App.Shared.Domians.Entities
{
    public class Coffee
    {
        public int Id { get; private set; }
        public string Description { get; private set; }
        public decimal ValueCoffee { get; private set; }
        public string MessageError { get; private set; }

        public Coffee(int id, string description, decimal valueCoffee)
        {
            this.Id = id;
            this.Description = description;
            this.ValueCoffee = valueCoffee;
            this.ValidationFields();
        }

        private void ValidationFields()
        {
            this.MessageError = string.Empty;

            if (this.Id == 0)
                this.MessageError = this.MessageError + "Id não informado\n";

            if (string.IsNullOrEmpty(this.Description))
                this.MessageError = this.MessageError + "Descrição não informada\n";

            if (this.ValueCoffee.Equals(0))
                this.MessageError = this.MessageError + "Valor não informada\n";
        }
    }
}