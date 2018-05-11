
using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace BlobTrigger
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task Run([BlobTrigger("test-container/{name}",
        Connection = "BlobStorageConnectionString")]CloudBlockBlob myBlob,
        string name, TraceWriter log)
        {
            log.Info($"C# Blob trigger function Processed blob\n Name:{name}");
            await myBlob.CreateSnapshotAsync();
        }

       


    }
    
}
