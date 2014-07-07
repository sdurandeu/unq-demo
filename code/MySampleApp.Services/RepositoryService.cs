namespace MySampleApp
{
    using System.Linq;
    using MySampleApp.Services;

    public class RepositoryService
    {
        public RepositoryService(IRepositoryClient client) 
        {
            this.Client = client;
        }

        public RepositoryService() 
        {
            this.Client = new GitHubRepositoryClient();
        }

        private IRepositoryClient Client { get; set; }

        public string[] GetUserPublicRepos(string user) 
        {          
            return this.Client.GetUserRepositories(user)
                .Where(r => !r.Private)
                .Select(r => r.Name).ToArray();
        }
    }
}
