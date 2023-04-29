namespace Client.Helper;

public static class CachedWithdrawMoney
{
    private static decimal _amount;

    public static void Set(decimal amount) => _amount = amount;

    public static decimal Get() => _amount;
}
