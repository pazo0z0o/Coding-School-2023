namespace PetShop.MVC.Models.Transactions
{
    public class MonthlyLedgerDTO
    {

        List<decimal> MonthIncome { get; set; } = new List<decimal>();

        List<decimal> MonthlyExpenses { get; set; } = new List<decimal>();

        List<decimal> Total { get; set; } = new List<decimal>();

    }
}
