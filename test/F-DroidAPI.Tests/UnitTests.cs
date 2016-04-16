namespace FDroidAPI.Test
{
    using System.Threading.Tasks;

    using FDroid;

    using Xunit;

    public class UnitTests
    {
        [Fact]
        public async Task GetRepo()
        {
            var repo = await Parser.GetRepo();
            Assert.NotNull(repo);
        }
    }
}
