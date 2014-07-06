namespace MySampleApp.Services
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using MySampleApp.Model;
    using Newtonsoft.Json;

    public class GitHubRepositoryClient : IRepositoryClient
    {
        private const string GetUserRepositoriesUrl = "https://api.github.com/users/{0}/repos";

        public IEnumerable<Repository> GetUserRepositories(string user)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(string.Format(GetUserRepositoriesUrl, user));
            request.UserAgent = "myTestApp";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);
            string responseString = reader.ReadToEnd();
            reader.Close();

            return JsonConvert.DeserializeObject<List<Repository>>(responseString);
        }
    }
}
