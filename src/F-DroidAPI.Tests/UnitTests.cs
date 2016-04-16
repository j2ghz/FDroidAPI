namespace FDroidAPI.Test
{
    using FDroid;

    using Xunit;

    public class UnitTests
    {
        [Fact]
        public void GetRepo()
        {
            Assert.NotNull(Parser.GetRepo());
        }
    }
}
