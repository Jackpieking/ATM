using ATM_DEMO_API.Services;

namespace Client.Helper;

public static class CachedRSAEncryptor
{
    private static RSAEncryptor _RSAEncryptor;

    public static RSAEncryptor Set(RSAEncryptor RSAEncryptor) => _RSAEncryptor = RSAEncryptor;

    public static RSAEncryptor Get()
    {
        _RSAEncryptor ??= new();

        return _RSAEncryptor;
    }
}
