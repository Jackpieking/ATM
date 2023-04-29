using ATM_DEMO_API.Services;
using Client.Helper;
using System;
using System.Windows.Forms;

namespace Client.View
{
    public partial class WithdrawSuccessfullyForm : Form
    {
        public WithdrawSuccessfullyForm()
        {
            InitializeComponent();
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
