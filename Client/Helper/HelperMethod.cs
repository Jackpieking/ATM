using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Helper;

public static class HelperMethod
{
    public static async Task RemoveUserAndServerConnection(string cardID)
    {
        using HttpClient client = new();

        var RemoveUserAndServerConnectionEndpointURL
            = $"https://localhost:7117/api/BankUser/RemoveConnection?cardID={cardID}";

        await client.DeleteAsync(requestUri: RemoveUserAndServerConnectionEndpointURL);
    }

    public static async Task ClosingFormAsync(FormClosingEventArgs e)
    {
        var result = MessageBox.Show(text: "Bạn có muốn thoát không ?",
                                     caption: "Thoát",
                                     buttons: MessageBoxButtons.YesNo);

        if (result is DialogResult.Yes)
        {
            const byte cardIDLength = 19;
            var cardID = CachedCardID.GetCardID();

            cardID ??= string.Empty;

            if (cardID.Length == cardIDLength)
                await RemoveUserAndServerConnection(cardID: cardID);

            CachedFormContainer.Get()?.Dispose();
            CachedHttpClient.Get()?.Dispose();
            CachedRSAEncryptor.Get()?.Dispose();

            Environment.Exit(exitCode: 0);
        }

        e.Cancel = true;
    }
}
