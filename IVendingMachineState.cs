namespace vendingmachine
{
    public interface IVendingMachineState
    {
        void DispenseProduct();
        void SelectProductAndInsertMoney(int amount, string productName);
    }
}