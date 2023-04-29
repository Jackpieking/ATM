namespace ATM_DEMO_API.Models;

public class BankUserInfo
{
    public string CardID { get; set; }

    public string Name { get; set; }

    public decimal Money { get; set; }

    public BankUserLoginInfo BankUserLoginInfo { get; set; }
}
