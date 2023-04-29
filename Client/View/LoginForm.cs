using Client.Helper;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginHeader_Click(object sender, EventArgs e)
        {

        }

        private void lblCardID_Click(object sender, EventArgs e)
        {

        }

        private void iptCardID_TextChanged(object sender, EventArgs e)
        {


        }

        private void iptPIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPIN_Click(object sender, EventArgs e)
        {

        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            var loginErrorform = CachedFormContainer.Get().GetLoginErrorForm();

            /* Validate PIN */
            if (!ValidatePIN())
            {
                loginErrorform.ShowDialog();

                cancelBtn_Click(sender: sender, e: e);
                return;
            }

            /* Validate CardID */
            if (!ValidateCardID())
            {
                loginErrorform.ShowDialog();

                cancelBtn_Click(sender: sender, e: e);
                return;
            }

            if (CachedServerRSAPublicKey.Get() is null)
                CachedServerRSAPublicKey.Set(key: await GetPublicKeyFromServerAsync());

            var validateUserResult = await ValidateUserLoginInfoAsync(serverPublicKey: CachedServerRSAPublicKey.Get());

            var loadingForm = CachedFormContainer.Get().GetLoadingForm();

            loadingForm.Show();
            await Task.Delay(millisecondsDelay: 1000);
            loadingForm.Hide();

            if (validateUserResult == false)
            {
                loginErrorform.ShowDialog();

                cancelBtn_Click(sender: sender, e: e);
                return;
            }

            CachedCardID.SetCardID(cardID: iptCardID.Text);

            cancelBtn_Click(sender: sender, e: e);
            Hide();
            CachedFormContainer.Get().GetUserMenuForm().Show();
        }

        private bool ValidatePIN()
        {
            const byte PINLength = 6;

            /* PIN length is 6 */
            if (iptPIN.Text.Length != PINLength)
                return false;

            /* PIN is a number */
            if (!int.TryParse(s: iptPIN.Text, result: out _))
                return false;

            return true;
        }

        private bool ValidateCardID()
        {
            const string splitor = "-";
            const byte cardIDLength = 19;

            /* Card ID has 19 character */
            if (iptCardID.Text.Length != cardIDLength)
                return false;

            var cardIDTokens = iptCardID.Text.Split(separator: splitor);

            /* Number of card tokens is 4 */
            if (cardIDTokens.Length != 4)
                return false;

            /* Card ID tokens are number */
            var allIsNumber = true;

            foreach (var token in cardIDTokens)
            {
                if (!short.TryParse(s: token, result: out _))
                {
                    allIsNumber = false;
                    break;
                }
            }

            if (!allIsNumber)
                return false;

            return true;
        }

        public Task<string> GetPublicKeyFromServerAsync()
        {
            const string GeneratePublicKeyEndpointURL = "https://localhost:7117/api/GenerateKey/PublicKey";

            return CachedHttpClient
                .Get()
                .GetStringAsync(requestUri: GeneratePublicKeyEndpointURL);
        }

        public async Task<bool> ValidateUserLoginInfoAsync(string serverPublicKey)
        {
            const string ValidateUserLoginEndpointURL = "https://localhost:7117/api/BankUser/Validate";

            var rsaEncryptor = CachedRSAEncryptor.Get();

            var userLoginInfo = new
            {
                CardID = iptCardID.Text,
                PIN = iptPIN.Text,
            };

            /* Encrypt the User Info */
            var encryptedUserLogInfoInBase64 = rsaEncryptor.Encrypt(plainText: JsonSerializer.Serialize(value: userLoginInfo),
                                                                    publicKey: serverPublicKey);

            StringContent content = new(content: JsonSerializer.Serialize(value: encryptedUserLogInfoInBase64),
                                        encoding: Encoding.Unicode,
                                        mediaType: MediaTypeNames.Application.Json);

            var response = await CachedHttpClient
                .Get()
                .PostAsync(requestUri: ValidateUserLoginEndpointURL,
                           content: content);

            if (response.StatusCode is HttpStatusCode.NoContent)
            {
                await CreateConnectionToServerAsync(cardID: userLoginInfo.CardID,
                                                    clientPublicKey: rsaEncryptor.GetPublicKey(),
                                                    serverPublicKey: serverPublicKey);
                return true;
            }

            return false;
        }

        private async Task CreateConnectionToServerAsync(string cardID,
                                                         string clientPublicKey,
                                                         string serverPublicKey)
        {
            const string CreateConnectionToServerEndpointURL = "https://localhost:7117/api/BankUser/CreateConnection";

            var cardIDAndPublicKey = new
            {
                CardID = cardID,
                RSAPublicKey = clientPublicKey
            };

            StringContent content = new(content: JsonSerializer.Serialize(value: cardIDAndPublicKey),
                                        encoding: Encoding.Unicode,
                                        mediaType: MediaTypeNames.Application.Json);

            var response = await CachedHttpClient
                .Get()
                .PostAsync(requestUri: CreateConnectionToServerEndpointURL,
                           content: content);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            iptCardID.Text = string.Empty;
            iptPIN.Text = string.Empty;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e: e);
            await HelperMethod.ClosingFormAsync(e: e);
        }
    }
}
