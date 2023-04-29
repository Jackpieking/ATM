using ATM_DEMO_API.Services;
using Client.Helper;
using System;
using System.Windows.Forms;

namespace Client.View
{
    public partial class UserMenuForm : Form
    {
        public UserMenuForm()
        {
            InitializeComponent();
        }

        private void withdrawMoneyBtn_Click(object sender, EventArgs e)
        {
            Hide();
            CachedFormContainer.Get().GetWithdrawForm().Show();
        }

        private async void viewBalanceBtn_Click(object sender, EventArgs e)
        {
            Hide();

            var viewBalanceForm = CachedFormContainer.Get().GetViewBalanceForm();

            await viewBalanceForm.DisplayBalanceOutput();
            viewBalanceForm.Show();
        }

        private void userMenuHeader_Click(object sender, EventArgs e)
        {

        }

        private void atmLogo_Click(object sender, EventArgs e)
        {

        }

        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e: e);
            await HelperMethod.ClosingFormAsync(e: e);
        }

        private async void logOutBtn_Click(object sender, EventArgs e)
        {
            CachedRSAEncryptor.Get().Dispose();
            CachedRSAEncryptor.Set(new RSAEncryptor());

            await HelperMethod.RemoveUserAndServerConnection(cardID: CachedCardID.GetCardID());

            Hide();
            CachedFormContainer.Get().GetLoginForm().Show();
        }
    }
}
