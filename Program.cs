using System;
using vendingmachine;

VendingMachine vendingMachine = new VendingMachine();
Console.WriteLine("Current VendingMachine State : "
                + vendingMachine.vendingMachineState.GetType().Name + "\n");
vendingMachine.DispenseProduct();
vendingMachine.SelectProductAndInsertMoney(1.00, "Cola");

Console.WriteLine("\nCurrent VendingMachine State : "
                + vendingMachine.vendingMachineState.GetType().Name + "\n");
vendingMachine.SelectProductAndInsertMoney(0.50, "chips");
vendingMachine.DispenseProduct();
Console.WriteLine("\nCurrent VendingMachine State : "
                + vendingMachine.vendingMachineState.GetType().Name + "\n");
vendingMachine.SelectProductAndInsertMoney(0.65, "candy");
vendingMachine.DispenseProduct();

Console.WriteLine("\nCurrent VendingMachine State : "
                + vendingMachine.vendingMachineState.GetType().Name);
Console.Read();

