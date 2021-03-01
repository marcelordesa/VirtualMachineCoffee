namespace VirtualMachineCoffee.App.Shared.Domians.Entities
{
    public static class CoinsType
    {
        public static decimal OneCents { get; private set; } = 0.01M;
        public static decimal FiveCents { get; private set; } = 0.05M;
        public static decimal TenCents { get; private set; } = 0.10M;
        public static decimal TwentyFiveCents { get; private set; } = 0.25M;
        public static decimal FiftyCents { get; private set; } = 0.50M;
        public static decimal OneReals { get; private set; } = 1.0M;
    }
}