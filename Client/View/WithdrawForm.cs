using Client.Helper;
using System;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.View
{
    public partial class WithdrawForm : Form
    {
        public WithdrawForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
            CachedFormContainer.Get().GetUserMenuForm().Show();
        }

        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e: e);
            await HelperMethod.ClosingFormAsync(e: e);
        }

        private async void withdraw200Btn_Click(object sender, EventArgs e)
        {
            const decimal withdrawAmount = 200_000;

            var balance = await DecryptBalanceAsync();

            decimal.TryParse(s: balance, result: out var balanceInDecimal);

            if (balanceInDecimal - withdrawAmount < 50_000)
            {
                DisplayInsufficientBalanceWarningDialog();
                return;
            }

            CachedWithdrawMoney.Set(amount: withdrawAmount);

            Hide();
            var confirmWithdrawForm = CachedFormContainer.Get().GetConfirmWithdrawForm();

            confirmWithdrawForm.UpdateWithdrawAmount();
            confirmWithdrawForm.Show();
        }

        private void DisplayInsufficientBalanceWarningDialog()
        {
            MessageBox.Show(text: "Số tiền không đủ !!",
                            caption: "Cảnh báo",
                            buttons: MessageBoxButtons.OK);
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

        private async void withdraw100Btn_Click(object sender, EventArgs e)
        {
            const decimal amount = 100_000;

            await withdrawMoneyAsync(amount);
        }

        private async Task withdrawMoneyAsync(decimal withdrawAmount)
        {
            var balance = await DecryptBalanceAsync();

            decimal.TryParse(s: balance, result: out var balanceInDecimal);

            if (balanceInDecimal - withdrawAmount < 50_000)
            {
                DisplayInsufficientBalanceWarningDialog();
                return;
            }

            CachedWithdrawMoney.Set(amount: withdrawAmount);

            Hide();
            var confirmWithdrawForm = CachedFormContainer.Get().GetConfirmWithdrawForm();

            confirmWithdrawForm.UpdateWithdrawAmount();
            confirmWithdrawForm.Show();
        }

        private async void withdraw200Btn_Click_1(object sender, EventArgs e)
        {
            const decimal amount = 200_000;

            await withdrawMoneyAsync(amount);
        }
    }
}
