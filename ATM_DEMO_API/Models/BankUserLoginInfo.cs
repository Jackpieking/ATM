namespace ATM_DEMO_API.Models;

public class BankUserLoginInfo
{
    public string CardID { get; set; }

    public string PIN { get; set; }

    public BankUserInfo BankUserInfo { get; set; }
}
