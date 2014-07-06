namespace MySampleApp
{
    using System;
    using MySampleApp;

    public class Program
    {
        public static void Main(string[] args)
        {
            RepositoryService service = new RepositoryService();

            var repos = service.GetUserPublicRepos("sdurandeu");

            foreach (string repo in repos)
            {
                Console.WriteLine(repo);
            }

            Console.ReadKey();
        }
    }
}
