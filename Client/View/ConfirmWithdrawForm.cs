using Client.Helper;
using System;
using System.Globalization;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View
{
    public partial class ConfirmWithdrawForm : Form
    {
        public ConfirmWithdrawForm()
        {
            InitializeComponent();
        }

        public void UpdateWithdrawAmount()
            => withdrawMoneyOutput.Text = CachedWithdrawMoney.Get().ToString("N0", CultureInfo.GetCultureInfo("es-ES")) + " VND";

        private void ConfirmWithdrawForm_Load(object sender, EventArgs e) { }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
            CachedFormContainer.Get().GetWithdrawForm().Show();
        }

        private async void confirmBtn_Click(object sender, EventArgs e)
        {
            await WithdrawMoneyAsync();

            Hide();
            CachedFormContainer
                .Get()
                .GetWithdrawSuccessfullyForm()
                .Show();
        }

        private async Task WithdrawMoneyAsync()
        {
            const string WithdrawEndpointURL = "https://localhost:7117/api/BankUser/Withdraw";

            var cardIDaAndWithdrawAmount = new
            {
                CardID = CachedCardID.GetCardID(),
                WithdrawAmount = CachedWithdrawMoney.Get()
            };

            /* Encrypt the User Info */
            var encryptedUserLogInfoInBase64 = CachedRSAEncryptor
                .Get()
                .Encrypt(plainText: JsonSerializer.Serialize(value: cardIDaAndWithdrawAmount),
                                                             publicKey: CachedServerRSAPublicKey.Get());

            StringContent content = new(content: JsonSerializer.Serialize(value: encryptedUserLogInfoInBase64),
                                        encoding: Encoding.Unicode,
                                        mediaType: MediaTypeNames.Application.Json);

            await CachedHttpClient
                .Get()
                .PostAsync(requestUri: WithdrawEndpointURL,
                           content: content);
        }

        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e: e);
            await HelperMethod.ClosingFormAsync(e: e);
        }

        private void withdrawMoneyOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
