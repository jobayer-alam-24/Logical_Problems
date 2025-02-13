namespace Profit_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"---------ABC Company Percentage Based Profit Calculation----------");
            StartCalculate();
        }
        static void StartCalculate()
        {
            float Profit, Expense, ExpenseAmount, SoftwareExpense, SoftwareExpenseAmount, SalesmansExpense, SalesmansExpenseAmount, ShareMarketInvest, ShareMarketInvestInAmount, PerSalesmanExpense, PerSalesmanExpenseInAmount, OwnerExpense, OwnerExpenseInAmount;
            int NumberOfSalesman;

            Console.Write("Enter Company Profit: ");
            Profit = float.Parse(Console.ReadLine());
            Console.Write("Enter the Number of Salesman in Your Company: ");
            NumberOfSalesman = int.Parse(Console.ReadLine());
            Console.WriteLine("------Taking Input as Percentage------");
            Console.Write("Enter Expense: ");
            Expense = float.Parse(Console.ReadLine());
            Console.Write("Enter Software Expense: ");
            SoftwareExpense = float.Parse(Console.ReadLine());
            Console.Write("Enter the Salesmans Expense: ");
            SalesmansExpense = float.Parse(Console.ReadLine());
            Console.Write("Enter the Share Market Invest: ");
            ShareMarketInvest = float.Parse(Console.ReadLine());
            PerSalesmanExpense = SalesmansExpense / NumberOfSalesman;
            OwnerExpense = 100 - (Expense + SoftwareExpense + SalesmansExpense + ShareMarketInvest);
            //Calculation
            ExpenseAmount = Profit * (Expense / 100);
            SalesmansExpenseAmount = Profit * (SalesmansExpense / 100);
            SoftwareExpenseAmount = Profit * (SoftwareExpense / 100);
            ShareMarketInvestInAmount = Profit * (ShareMarketInvest / 100);
            PerSalesmanExpenseInAmount = SalesmansExpenseAmount / NumberOfSalesman;
            OwnerExpenseInAmount = Profit * (OwnerExpense / 100);
            //Printing 
            Console.WriteLine("---------CALCULATED AMOUNT----------");
            Console.WriteLine($"Profit: {Profit}$");
            Console.WriteLine($"===================");
            Console.WriteLine($"Expense Amount: {ExpenseAmount}$ in {Expense}%");
            Console.WriteLine($"Software Expense Amount: {SoftwareExpenseAmount}$ in {SoftwareExpense}%");
            Console.WriteLine($"Sales Man Expense Amount: {SalesmansExpenseAmount}$ in {SalesmansExpense}%");
            Console.WriteLine($"Per Sales Man Expense Amount: {PerSalesmanExpenseInAmount}$ in {PerSalesmanExpense}%");
            Console.WriteLine($"Share Market Invest Amount: {ShareMarketInvestInAmount}$ in {ShareMarketInvest}%");
            Console.WriteLine($"Owner Expense Amount: {OwnerExpenseInAmount}$ in {OwnerExpense}%");
        }
    }
}