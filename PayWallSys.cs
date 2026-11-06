using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_MachineProblem_WizardsLair
{
    public partial class PayWallSys : Form
    {
        // ui
        private ComboBox cmbBankService;
        private Button btnGetLink;
        private Button btnRevive;
        private Label lblStatus;
        private const decimal FIXED_PRICE = 20.00m;

        public bool ReviveGranted { get; private set; }

        public PayWallSys()
        {
            SetupUI();
        }

        private void SetupUI()
        {
            this.Text = "Real Payment Gateway - Wizard's Lair";
            this.Size = new Size(400, 450);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblMethod = new Label { Text = "Select Real Payment Method:", Location = new Point(20, 20), AutoSize = true };
            cmbBankService = new ComboBox { Location = new Point(20, 40), Width = 340, DropDownStyle = ComboBoxStyle.DropDownList };
            cmbBankService.Items.AddRange(new object[] { "PayPal", "PayMongo (Maya / GoTyme / QRPh)" });
            cmbBankService.SelectedIndex = 0;

            btnGetLink = new Button { Text = "Generate Real Checkout Link", Location = new Point(20, 80), Width = 340, Height = 45 };
            btnGetLink.Click += BtnGetLink_Click;

            btnRevive = new Button
            {
                Text = "Get +1 Revive",
                Location = new Point(20, 250),
                Width = 340,
                Height = 35,
                Enabled = false
            };
            btnRevive.Click += ReviveBtn_Click;

            lblStatus = new Label { Location = new Point(20, 140), Width = 340, Height = 100, ForeColor = Color.Blue };

            this.Controls.AddRange(new Control[] { lblMethod, cmbBankService, btnGetLink, lblStatus, btnRevive });
        }

        private async void BtnGetLink_Click(object sender, EventArgs e)
        {
            btnGetLink.Enabled = false;
            lblStatus.Text = "Contacting bank servers via API...\nPlease wait.";

            try
            {
                string checkoutUrl = "";

                if (cmbBankService.SelectedItem.ToString() == "PayPal")
                {
                    checkoutUrl = await RealPayPalAPI.CreateOrderAsync(FIXED_PRICE);
                }
                else
                {
                    checkoutUrl = await RealPayMongoAPI.CreateCheckoutAsync(FIXED_PRICE);
                }

                lblStatus.Text = "API Success! Opening secure browser...";

                // dont touch
                Process.Start(new ProcessStartInfo
                {
                    FileName = checkoutUrl,
                    UseShellExecute = true
                });

                lblStatus.Text = "Browser opened. Complete the payment, then click Get +1 Revive.";
                btnRevive.Enabled = true;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "API Error: " + ex.Message + "\n(Did you replace the API keys?)";
                lblStatus.ForeColor = Color.Red;
            }
            finally
            {
                btnGetLink.Enabled = true;
            }
        }

        private void ReviveBtn_Click(object sender, EventArgs e)
        {
            ReviveGranted = true;
            MessageBox.Show("Payment successful! You received +1 revive.", "Payment Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }

    // api
    public static class RealPayPalAPI
    {
        // paypal
        private const string CLIENT_ID = "BAAQgpgVszr0cggiCSe-M5-Gyikhug_An0A-HU5koqNe_XVEdEWxLPh23bGxWxATrb3sbqQRFzSkbnE13I";
        private const string CLIENT_SECRET = "EBzHq9hc0Bz4U0SrdqpW6AkK5saKduI6KqjVdOYYoQt_6DAw9a2P9NJxOa1e1oobIpCinIn9rmOBTucR";
        private const string API_BASE = "https://api-m.sandbox.paypal.com"; // Use live for real money

        public static async Task<string> CreateOrderAsync(decimal amount)
        {
            using (HttpClient client = new HttpClient())
            {
               
                var authBytes = Encoding.ASCII.GetBytes($"{CLIENT_ID}:{CLIENT_SECRET}");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authBytes));

                var tokenRequest = new StringContent("grant_type=client_credentials", Encoding.UTF8, "application/x-www-form-urlencoded");
                var tokenResponse = await client.PostAsync($"{API_BASE}/v1/oauth2/token", tokenRequest);
                if (!tokenResponse.IsSuccessStatusCode) throw new Exception("PayPal Auth Failed.");

                var tokenJson = await tokenResponse.Content.ReadAsStringAsync();
                JObject tokenDoc = JObject.Parse(tokenJson);
                string accessToken = (string)tokenDoc["access_token"];

       
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                var orderPayload = new
                {
                    intent = "CAPTURE",
                    purchase_units = new[]
                    {
                        new { amount = new { currency_code = "PHP", value = amount.ToString("F2") } }
                    },
                    application_context = new
                    {
                        return_url = "http://localhost:8080/success",
                        cancel_url = "http://localhost:8080/cancel"
                    }
                };

                string jsonContent = JsonConvert.SerializeObject(orderPayload);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var orderResponse = await client.PostAsync($"{API_BASE}/v2/checkout/orders", content);
                if (!orderResponse.IsSuccessStatusCode) throw new Exception("Order Creation Failed.");

                var orderJson = await orderResponse.Content.ReadAsStringAsync();

          
                JObject orderDoc = JObject.Parse(orderJson);
                JArray links = (JArray)orderDoc["links"];
                foreach (JToken link in links)
                {
                    if ((string)link["rel"] == "approve")
                    {
                        return (string)link["href"];
                    }
                }
                throw new Exception("Approval URL not found.");
            }
        }
    }

    // maya gotyme
    public static class RealPayMongoAPI
    {
       
        private const string SECRET_KEY = "sk_test_YOUR_PAYMONGO_SECRET_KEY";

        public static async Task<string> CreateCheckoutAsync(decimal amount)
        {
            using (HttpClient client = new HttpClient())
            {
                var authBytes = Encoding.ASCII.GetBytes($"{SECRET_KEY}:"); // PayMongo uses Secret 
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authBytes));

                var checkoutPayload = new
                {
                    data = new
                    {
                        attributes = new
                        {
                            send_email_receipt = true,
                            show_description = true,
                            show_line_items = true,
                            line_items = new[]
                            {
                                new { name = "Wizard's Lair Access", amount = (int)(amount * 100), currency = "PHP", quantity = 1 } // PayMongo uses cents (20.00 * 100)
                            },
                            payment_method_types = new[] { "paymaya", "qrph", "dob" }, //direct online banking
                            success_url = "https://yourwebsite.com/success",
                            cancel_url = "https://yourwebsite.com/cancel"
                        }
                    }
                };

                string jsonContent = JsonConvert.SerializeObject(checkoutPayload);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://api.paymongo.com/v1/checkout_sessions", content);
                if (!response.IsSuccessStatusCode)
                {
                    string error = await response.Content.ReadAsStringAsync();
                    throw new Exception("PayMongo API Failed: " + error);
                }

                var responseJson = await response.Content.ReadAsStringAsync();

                // Parse the checkout URL returned by PayMongo
                JObject doc = JObject.Parse(responseJson);
                return (string)doc["data"]["attributes"]["checkout_url"];
            }
        }
    }
}