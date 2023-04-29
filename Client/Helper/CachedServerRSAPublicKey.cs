namespace Client.Helper;

public static class CachedServerRSAPublicKey
{
    private static string _key;

    public static void Set(string key) => _key = key;

    public static string Get() => _key;
}
