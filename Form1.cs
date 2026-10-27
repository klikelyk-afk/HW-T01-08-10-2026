using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace WinFormsApp_DNS_511
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetIp_Click(object sender, EventArgs e)
        {
            // IPHostEntry
            // IPAddress
            listBoxAddresses.Items.Clear();

            string url = textBoxHostName.Text;
            url = url.Trim();
            string host = ExtractHost(url);

            try
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(host);
                IPAddress[] addresses = hostEntry.AddressList;
                if (addresses.Length > 0)
                {
                    foreach (var item in addresses)
                    {
                        listBoxAddresses.Items.Add(item.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonGetHost_Click(object sender, EventArgs e)
        {
            string ipText = textBoxIpAddress.Text.Trim();

            try
            {
                IPAddress ip = IPAddress.Parse(ipText);
                IPHostEntry entry = Dns.GetHostEntry(ip);
                labelHostName.Text = entry.HostName;

                Debug.WriteLine($"Host name: {entry.HostName}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string ExtractHost(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                // income - en.wikipedia.org
                if (!url.StartsWith("https://", StringComparison.OrdinalIgnoreCase)
                    && !url.StartsWith("http://", StringComparison.OrdinalIgnoreCase))
                {
                    // https://en.wikipedia.org
                    url = "https://" + url;
                }

                Uri uri = new Uri(url);
                return uri.Host;
            }

            return string.Empty;
        }

        private int maxHops = 30; // стрибки
        private int timeout = 1000; // in miliseconds

        // ox.ac.uk (Оксфордський університет, Велика Британія)
        // uic.es (Університет Каталонії, Іспанія)
        // CERN.ch (Європейська організація з ядерних досліджень, Швейцарія)
        // mit.edu (Массачусетський технологічний інститут)
        // stanford.edu (Стенфордський університет)
        // nasa.gov (NASA, США)
        // u-tokyo.ac.jp (Токійський університет, Японія)
        // nus.edu.sg (Національний університет Сінгапуру)
        // unimelb.edu.au (Мельбурнський університет, Австралія)
        // nyu.edu (Нью-Йоркський університет)

        private void button1_Click(object sender, EventArgs e)
        {
            CheckRoutes();
        }

        private void CheckRoutes()
        {
            CheckRoute("CERN.ch");
        }

        private void CheckRoute(string host)
        {
            //StringBuilder stringBuilder = new StringBuilder();

            using Ping pingSender = new Ping();

            //byte[] buffer = Encoding.UTF8.GetBytes("data");
            byte[] buffer = Encoding.ASCII.GetBytes("data");

            for (int ttl = 1; ttl <= maxHops; ttl++)
            {
                // Set the Time-to-Live (TTL) for this specific iteration// The 'true' flag prevents the packet from being fragmented
                PingOptions options = new PingOptions(ttl, true);
                // Send the ICMP Echo request
                PingReply reply = pingSender.Send(host, timeout, buffer, options);

                if (reply.Status == IPStatus.TtlExpired)
                {
                    // The packet "died" at an intermediate router, providing us its IP
                    Debug.WriteLine($"{ttl,2} | IP: {reply.Address,-15} | Time: {reply.RoundtripTime}ms");
                }
                else if (reply.Status == IPStatus.Success)
                {
                    // The packet successfully reached the final destination
                    Debug.WriteLine($"{ttl,2} | IP: {reply.Address,-15} | Reached! Final ping: {reply.RoundtripTime}ms");
                    break;
                }
                else if (reply.Status == IPStatus.TimedOut)
                {
                    // The router or destination host did not respond within the timeout period
                    Debug.WriteLine($"{ttl,2} | IP: * * * | Request timed out");
                }
                else
                {
                    // Handle other possible network errors (e.g., Destination Unreachable)
                    Debug.WriteLine($"{ttl,2} | Error: {reply.Status}");
                }
            }

            Debug.WriteLine("\nTrace complete.");
        }





        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string newIp = textBoxNewIp.Text.Trim();
            if (!string.IsNullOrEmpty(newIp))
            {
                if (!listBoxAddresses.Items.Contains(newIp))
                {
                    listBoxAddresses.Items.Add(newIp);
                    textBoxNewIp.Clear();
                }
                else
                {
                    MessageBox.Show("This IP address is already in the list!");
                }
            }
            else
            {
                MessageBox.Show("Please enter an IP address!");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxAddresses.SelectedItem != null)
            {
                listBoxAddresses.Items.Remove(listBoxAddresses.SelectedItem);
            }
            else
            {
                MessageBox.Show("Select an IP address from the list to remove!");
            }
        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            if (listBoxAddresses.SelectedItem == null)
            {
                MessageBox.Show("Select an IP address from the list to ping!");
                return;
            }

            string ipAddress = listBoxAddresses.SelectedItem.ToString() ?? string.Empty;
            if (string.IsNullOrEmpty(ipAddress)) return;

            listBoxPingResult.Items.Clear();

            try
            {
                using (Ping pingSender = new Ping())
                {
                    for (int i = 0; i < 3; i++)
                    {
                        PingReply reply = pingSender.Send(ipAddress, 1000);
                        if (reply.Status == IPStatus.Success)
                        {
                            listBoxPingResult.Items.Add($"Ping to {ipAddress} successful: {reply.RoundtripTime}ms");
                        }
                        else
                        {
                            listBoxPingResult.Items.Add($"Ping to {ipAddress} failed: {reply.Status}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }