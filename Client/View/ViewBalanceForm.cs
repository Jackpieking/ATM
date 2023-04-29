using Client.Helper;
using System;
using System.Globalization;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View
{
    public partial class ViewBalanceForm : Form
    {
        public ViewBalanceForm()
        {
            InitializeComponent();
        }

        private async Task<string> GetuserBalanceAsync()
        {
            var getUserInfoByCardIDEndpointURL
                = $"https://localhost:7117/api/BankUser/UserInfo?cardID={CachedCardID.GetCardID()}";

            var client = CachedHttpClient.Get();

            return JsonSerializer.Deserialize(await client.GetStringAsync(requestUri: getUserInfoByCardIDEndpointURL), typeof(string)) as string;
        }

        private async Task<string> DecryptBalanceAsync()
        {
            var encryptedBalance = await GetuserBalanceAsync();

            var rsaEncryptor = CachedRSAEncryptor.Get();

            return rsaEncryptor.Decrypt(cipherText: encryptedBalance);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            balanceOutput.Text = string.Empty;

            Hide();
            CachedFormContainer.Get().GetUserMenuForm().Show();
        }

        private void balanceOutput_Click(object sender, EventArgs e)
        {

        }

        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e: e);
            await HelperMethod.ClosingFormAsync(e: e);
        }

        private void ViewBalanceForm_Load(object sender, EventArgs e) { }

        public async Task DisplayBalanceOutput()
        {
            var balance = await DecryptBalanceAsync();

            decimal.TryParse(balance, out var balanceInInt);

            balanceOutput.Text = balanceInInt.ToString("N0", CultureInfo.GetCultureInfo("es-ES")) + " VND";
        }
    }
}
