namespace Client.Helper;

public static class CachedCardID
{
    private static string _cardID;

    public static void SetCardID(string cardID) => _cardID = cardID;

    public static string GetCardID() => _cardID ?? null;
}
