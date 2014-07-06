namespace MySampleApp.Tests
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Diagnostics.CodeAnalysis;

    [ExcludeFromCodeCoverage]
    [TestClass]
    public class RepositoryServiceFixture
    {
        [TestMethod]
        public void ShouldRetrieveUserRepositories()
        {
            var service = new RepositoryService(new RepositoryClientMock());

            var repos = service.GetUserPublicRepos("testUser");

            Assert.IsNotNull(repos);

            Assert.IsTrue(repos.Count() > 0);

            Assert.IsNotNull(repos[0] == "Test Repo");
        }
    }
}
