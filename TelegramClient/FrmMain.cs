using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeleSharp.TL;
using TeleSharp.TL.Contacts;
using TeleSharp.TL.Messages;
using TLSharp.Core;

namespace TelClient
{
    public partial class Form1 : Form
    {
        private string seshash;

        //apiId и apiHash из получите  https://my.telegram.org/apps 
        private int apiId = ???;
        private string apiHash = "???";


        private TelegramClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnConnect_ClickAsync(object sender, EventArgs e)
        {
            client = new TelegramClient(apiId, apiHash);
            await client.ConnectAsync();
        }

        private async void btnSendCodeRequest_ClickAsync(object sender, EventArgs e)
        {
            seshash = await client.SendCodeRequestAsync(edTelNum.Text);
        }

        private async void btnSetSMS_Code_ClickAsync(object sender, EventArgs e)
        {
            var user = await client.MakeAuthAsync(edTelNum.Text, seshash, edSMScode.Text);
        }

        private async void btnImportedContacts_ClickAsync(object sender, EventArgs e)
        {
            Random rand = new Random();

            var us = File.ReadAllText(@"c:\Works\InitVCardContacts\tel.json");
            var ul = Newtonsoft.Json.JsonConvert.DeserializeObject<List<UserModel>>(us);

            int i = 0;
            foreach (var it in ul)
            {

                //var usr = await client.IsPhoneRegisteredAsync(it.tel);
                //if (!usr) return;

                try
                {
                    TLVector<TLInputPhoneContact> vectorInputPhoneContact = new TLVector<TLInputPhoneContact>();
                    vectorInputPhoneContact.Add(new TLInputPhoneContact
                    {
                        FirstName = it.FirstName,
                        LastName = it.LastName,
                        Phone = it.tel
                    });

                    TLImportedContacts importedContacts = await client.SendRequestAsync<TLImportedContacts>(new TLRequestImportContacts
                    {
                        Contacts = vectorInputPhoneContact
                    });

                    //TLVector<TLAbsUser> vectorAbsUser = importedContacts.Users;
                    //foreach (TLAbsUser absUser in vectorAbsUser)
                    //{
                    //    if (absUser.GetType() == typeof(TLUser))
                    //    {
                    //        TLUser user = (TLUser)absUser;

                    //        it.id = user.Id;
                    //        it.AccessHash = user.AccessHash.ToString();
                    //        it.Username = user.Username;
                    //    }
                    //}

                }
                catch (Exception ee)
                {
                    await DelayTelegramServer(ee.Message);
                }

                i++;
                SaveIndexToFile(i);


                this.Text = $"{ul.Count} из {i}";
                Application.DoEvents();

                await Task.Delay(rand.Next(3000, 5000));
                Console.WriteLine(i);

            }

            var rs = Newtonsoft.Json.JsonConvert.SerializeObject(ul);
            File.WriteAllText(@"c:\Works\InitVCardContacts\tel_New.json", rs);
        }

        private void SaveIndexToFile(int i)
        {
            File.WriteAllText("index.txt", i.ToString());
        }

        private int LoadIndex()
        {
            var s = File.ReadAllText("index.txt");
            if (int.TryParse(s, out var si))
                return si;
            else
                return 0;
        }

        private async Task DelayTelegramServer(string s)
        {
            /*
                 TLSharp.Core.Network.FloodException: 'Flood prevention. Telegram now requires your program to do requests again only after 120 seconds have passed (TimeToWait property). If you think the culprit of this problem may lie in TLSharp's implementation, open a Github issue please.'                 
            */

            var sb = s.IndexOf("only after");
            var se = s.IndexOf("seconds");

            if (sb != -1)
            {
                var sec = s.Substring(sb + 10, se - sb - 10).Trim();
                if (int.TryParse(sec, out var si))
                    await Task.Delay(si + 3);
            }
        }
    }
}
