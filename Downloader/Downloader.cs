using System.IO;
using System;
using System.Net;
using System.Windows.Forms;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Security.Policy;
using System.Windows.Forms.VisualStyles;

namespace Downloader
{
    public partial class Downloader : Form
    {
        public Downloader()
        {
            InitializeComponent();

            //by using new HTTPWebRequest
            download_pb.Click += async (sender, e) =>
            {
                string exePath = AppDomain.CurrentDomain.BaseDirectory;
                string url = link_txt.Text;
                string fileName = Path.GetFileName(url);
                string savePath = Path.Combine(exePath, fileName);
                //result_pb.Value = 0;
                //this.Text = "Downloader";
                //size_lbl.Text = "Размер";

                await Task.Run(async () =>
                {
                    try
                    {
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                        request.Method = "GET";

                        using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                        {
                            string size = ((double)response.ContentLength / 1048576).ToString("#.# MB");
                            size_lbl.Text = $"Размер {size}";

                            //Обновление UI безопасно с использованием Invoke
                            size_lbl.Invoke(new Action(() => size_lbl.Text = $"Размер {size}"));

                            using (Stream responseStream = response.GetResponseStream())
                            using (FileStream fileStream = new FileStream(savePath, FileMode.Create))
                            {
                                byte[] buffer = new byte[8192]; // Буфер размером 8 КБ
                                long totalBytes = response.ContentLength;
                                long bytesDownloaded = 0;
                                int bytesRead;

                                string[] list = new string[] { size, url };
                                listView.Items.Add(fileName).SubItems.AddRange(list);

                                while ((bytesRead = await responseStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                                {
                                    fileStream.Write(buffer, 0, bytesRead);
                                    bytesDownloaded += bytesRead;

                                    //Вычисляем и обновляем прогресс
                                    int progressPercentage = (int)((bytesDownloaded * 100) / totalBytes);

                                    result_pb.Invoke(new Action(() =>
                                    {
                                        this.Text = $"Downloader {progressPercentage}% ({bytesDownloaded / 1048576.0:#.# MB})";
                                        result_pb.Value = progressPercentage;
                                    }));
                                }

                                listView.Items.RemoveAt(0);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Exception");
                    }
                });
            };

            add_pb.Click += (sender, e) => 
            {
            };

            //by using old WebClient
            //download_pb.Click += (sender, e) =>
            //{
            //    string exePath = AppDomain.CurrentDomain.BaseDirectory;
            //    string url = link_txt.Text;
            //    string fileName = Path.GetFileName(url);
            //    string savePath = Path.Combine(exePath, fileName);
            //    result_pb.Value = 0;
            //    this.Text = "Downloader";
            //    size_lbl.Text = "Размер";

            //    try
            //    {
            //        using (WebClient webClient = new WebClient())
            //        {
            //            webClient.OpenRead(url);
            //            string size = (Convert.ToDouble(webClient.ResponseHeaders["Content-Length"]) / 1048576).ToString("#.# MB");
            //            size_lbl.Text = $"Размер {size}";
            //            string[] list = new string[] { size, url };
            //            listView.Items.Add(fileName).SubItems.AddRange(list);

            //            webClient.DownloadProgressChanged += (s, a) =>
            //            {
            //                this.Text = $"Downloader {a.ProgressPercentage}% ({(double)a.BytesReceived / 1048576:#.# MB})";
            //                result_pb.Value = a.ProgressPercentage;
            //            };

            //            webClient.DownloadFileCompleted += (s, a) =>
            //            {
            //                if (a.Error == null)
            //                    listView.Items.RemoveAt(0);
            //                else
            //                    Console.WriteLine($"Произошла ошибка: {a.Error.Message}");
            //            };
            //            webClient.DownloadFileAsync(new Uri(url), savePath);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Exception");
            //    }
            //};           
        }
    }
}
