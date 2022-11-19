using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;

using EmployeesDIR;

namespace WebApi
{
    class WebApi
    {
        private HttpClient client;
        public WebApi()
        {
            client = new HttpClient();
        }
        public async Task<string> GetAsync(string url)
        {
            DialogResult result = (DialogResult)(-1);
            try
            {
                HttpResponseMessage message = client.GetAsync(url).Result;
                if (message.IsSuccessStatusCode == false)
                {
                    General.logger.ErrorFormat("Fail Http Status: {0}", message.StatusCode);
                    result = MessageBox.Show("Http Status:" + message.StatusCode + message.ReasonPhrase, General.title, MessageBoxButtons.RetryCancel);
                    if (result == DialogResult.Retry) { General.logger.Debug("Dialog Retry"); return GetAsync(url).Result; }
                }
                else
                {
                    return await message.Content.ReadAsStringAsync();
                }
                return "";
            }
            catch (HttpRequestException e)
            {
                General.logger.ErrorFormat("Http Request Error: {0}", e.Message);
                ErrorForm errorForm = new ErrorForm(e.Message);
                errorForm.Show();
                return "";
            }
        }
        /*
        public static void CheckUpdate()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            List<string> asserts = new List<string>();
            WebApi web = new WebApi();
            string source = "";
            switch (General.Config.Update.source)
            {
                case "Github":
                    {
                        web.client.DefaultRequestHeaders.Add("User-Agent", "request");
                        source = web.GetAsync("https://api.github.com/repos/GLgele/EmployeesDIR-Cs/releases/latest").Result;
                        source = source.Replace("\r", "").Replace("\n", "").Replace("\t", "");
                        GithubRelease release = JsonConvert.DeserializeObject<GithubRelease>(source);
                        break;
                    }
                case "Gitee":
                    {
                        source = web.GetAsync("https://gitee.com/api/v5/repos/GLgele/EmployeesDIR-Cs/releases/latest").Result;
                        break;
                    }
            }
        }
        */
        public static void CheckUpdate(object sender, EventArgs e)
        {
            CheckUpdate();
        }
        public static void CheckUpdate()
        {
            GitHubUpdater.UpdateClient client = new GitHubUpdater.UpdateClient() { Author = "GLgele", RepositoryName = "EmployeesDIR-Cs", CurrentInstalledVersion = new Version(3,1,0) };
            client.CheckIfLatest();
        }
    }
}
