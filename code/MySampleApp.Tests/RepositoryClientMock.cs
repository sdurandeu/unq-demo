namespace MySampleApp.Tests
{
    using MySampleApp.Model;
    using MySampleApp.Services;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    [ExcludeFromCodeCoverage]
    public class RepositoryClientMock : IRepositoryClient
    {
        IEnumerable<Repository> IRepositoryClient.GetUserRepositories(string user)
        {
            return new[] { new Repository() { Name = "Test Repo", Private = false } };
        }
    }
}
