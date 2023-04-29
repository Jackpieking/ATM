using System.Net.Http;

namespace Client.Helper;

public static class CachedHttpClient
{
    private static HttpClient _httpClient;

    public static HttpClient Get()
    {
        _httpClient ??= new();
        return _httpClient;
    }
}
