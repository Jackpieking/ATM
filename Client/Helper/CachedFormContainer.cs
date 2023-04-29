using Client.Services;

namespace Client.Helper;

public static class CachedFormContainer
{
    private static FormContainer _formContainer;

    public static FormContainer Get()
    {
        _formContainer ??= new();
        return _formContainer;
    }
}
