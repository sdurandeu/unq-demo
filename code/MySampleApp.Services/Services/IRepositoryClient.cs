namespace MySampleApp.Services
{
    using System;
    using System.Collections.Generic;
    using MySampleApp.Model;

    public interface IRepositoryClient
    {
        IEnumerable<Repository> GetUserRepositories(string user);
    }
}
