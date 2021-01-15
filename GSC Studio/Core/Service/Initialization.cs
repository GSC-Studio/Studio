using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSC_Studio.Core.Service
{
    public class Initialization
    {
        internal static readonly string CACHE_PATH = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/.gscCache");
        internal static readonly string PROJECT_PATH = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/GSC Repository");

        public Initialization()
        { }

        public bool CacheExists() => Directory.Exists(CACHE_PATH);

        public bool ProjectExists() => Directory.Exists(PROJECT_PATH);

        public void CreateCacheFolder()
        {
            DirectoryInfo e = Directory.CreateDirectory(CACHE_PATH);
            e.Attributes = FileAttributes.Hidden;
        }

        public void CreateFileInCache(string name, string value)
        {
            FileStream stream = File.Create(CACHE_PATH + "/" + name);
            stream.Write(Encoding.UTF8.GetBytes(value), 0, Encoding.UTF8.GetByteCount(value));
        }

        public string ReadFileFromCache(string name) => File.ReadAllText(CACHE_PATH + "/" + name);

        public List<string> GetFilesFromCache() => Directory.GetFiles(CACHE_PATH).ToList();

        public void CreateProjectFolder()
        {
            DirectoryInfo e = Directory.CreateDirectory(PROJECT_PATH);
            e.Attributes = FileAttributes.Normal;
        }

        public List<string> GetFoldersFromProject() => Directory.GetDirectories(CACHE_PATH).ToList();

        public void CreateRepositoryToCache(string url, params string[] rename)
        {
            var path = CACHE_PATH + "/GSC_STUDIO_META.zip";
            using (var client = new System.Net.Http.HttpClient())
            {
                var result = client.GetByteArrayAsync(url).Result;
                File.WriteAllBytes(path, result);
                ZipFile.ExtractToDirectory(path, CACHE_PATH + "/");
                File.Delete(path);
                Directory.Move(CACHE_PATH + rename[0], CACHE_PATH + rename[1]);
            }
        }
    }
}
