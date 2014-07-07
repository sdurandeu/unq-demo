namespace MySampleApp.Tests
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using MySampleApp.Model;
    using MySampleApp.Services;

    [ExcludeFromCodeCoverage]
    public class RepositoryClientMock : IRepositoryClient
    {
        IEnumerable<Repository> IRepositoryClient.GetUserRepositories(string user)
        {
            return new[] { new Repository() { Name = "Test Repo", Private = false } };
        }
    }
}
