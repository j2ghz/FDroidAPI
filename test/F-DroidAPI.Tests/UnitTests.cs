namespace FDroidAPI.Test
{
    using System.Threading.Tasks;

    using FDroid;

    using Xunit;

    public class UnitTests
    {
        private readonly Repo repo = Parser.GetRepo().Result;

        [Fact]
        public void GetRepo()
        {
            Assert.NotNull(this.repo);
        }

        [Fact]
        public void RepoContainsRepoInfo()
        {
            Assert.NotNull(this.repo.repo);
            Assert.NotEqual("", this.repo.repo.name);
        }

        [Fact]
        public void  RepoContainsAppsWithIds()
        {
            Assert.NotEmpty(this.repo.applications);
            Assert.All(this.repo.applications,app => Assert.NotEqual("",app.id));
        }
    }
}
