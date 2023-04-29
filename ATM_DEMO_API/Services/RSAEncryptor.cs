using System;
using System.Security.Cryptography;
using System.Text;

namespace ATM_DEMO_API.Services;

public class RSAEncryptor : IDisposable
{
    private readonly RSA _rsa;
    private readonly RSACryptoServiceProvider _csp;
    private bool disposedValue;

    public RSAEncryptor()
    {
        _rsa = RSA.Create();
        _csp = new();
    }

    public string GetPublicKey() => _rsa.ToXmlString(includePrivateParameters: false);

    public string Encrypt(string plainText, string publicKey)
    {
        _csp.FromXmlString(xmlString: publicKey);

        var data = Encoding.Unicode.GetBytes(s: plainText);

        var encryptedData = _csp.Encrypt(rgb: data, fOAEP: false);

        return Convert.ToBase64String(inArray: encryptedData);
    }

    public string Decrypt(string cipherText)
    {
        var dataBytes = Convert.FromBase64String(s: cipherText);

        _csp.ImportParameters(parameters: _rsa.ExportParameters(includePrivateParameters: true));

        var decryptData = _csp.Decrypt(rgb: dataBytes, fOAEP: false);

        return Encoding.Unicode.GetString(bytes: decryptData);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
                _csp.Dispose();
                _rsa.Dispose();
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~RSAEncryptor()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
