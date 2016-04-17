using System;

namespace FDroid
{
    using System.IO;
    using System.Threading.Tasks;
    using System.Xml.Serialization;

    using FDroidAPI;

    public static class Parser
    {
        private const string MainRepo = @"https://f-droid.org/repo/index.xml";

        public static async Task<Repo> GetRepo(string url)
        {
            var xml = new XmlSerializer(typeof(Repo));
            var stream = await GetRepoStream(url);
            var repo = xml.Deserialize(stream);
            return (Repo)repo;
        }

        public static async Task<Repo> GetRepo()
        {
            return await GetRepo(MainRepo);
        }

        private static async Task<Stream> GetRepoStream(string url)
        {
            var req = new System.Net.Http.HttpClient();
            var res = await req.GetAsync(url);
            return await res.Content.ReadAsStreamAsync();
        }

    }
}
