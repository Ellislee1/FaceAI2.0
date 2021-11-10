using System;  
using Azure.Storage.Blobs;  
using Azure.Storage.Blobs.Models;  
using System.IO;  
using System.Threading.Tasks;
using System.Configuration;
using Azure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Drawing;
using FaceAI.Classes;
using Microsoft.WindowsAzure.Storage;

namespace FaceAI.Azure.Database
{
    class BlobHandler
    {
        static readonly string BLOB_KEY = "PdpA+IDe5XkRQ/1HYx8CtaPtbMUa+JkydAbrJbv8eKosVuouW6YFARct+QzyhpobHaCjhFzA8RtCA+fyi8tJfw==";
        static readonly string CONTAINER = "faces";

        static readonly string CONNECTION = ConfigurationManager.AppSettings.Get("BLOB_ENDPOINT");
        public static async Task<BlobImage> UploadToStorage(string path, string fileName)
        {
            // Location of the blob and the file to be stored on that blob
            string url = "https://6221faces.blob.core.windows.net/faces/" + fileName;
            Uri blobUri = new Uri(url);

            // Create credentials
            StorageSharedKeyCredential storageCredentials = new StorageSharedKeyCredential("6221faces", BLOB_KEY);

            // Create client
            BlobClient blobClient = new BlobClient(blobUri, storageCredentials);

            // Create File Stream
            FileStream fileStream = File.OpenRead(path);

            // Upload file to blob
            await blobClient.UploadAsync(fileStream);

            fileStream.Close();

            BlobImage image = new BlobImage(fileName, url);
            return image;
        }

        public static async void DownloadToTemp(string path, string fileName)
        {
            string storageAccount_connectionString = "DefaultEndpointsProtocol=https;AccountName=6221faces;AccountKey=PdpA+IDe5XkRQ/1HYx8CtaPtbMUa+JkydAbrJbv8eKosVuouW6YFARct+QzyhpobHaCjhFzA8RtCA+fyi8tJfw==;EndpointSuffix=core.windows.net";

            CloudStorageAccount mycloudStorageAccount = CloudStorageAccount.Parse(storageAccount_connectionString);
            CloudBlobClient blobClient = mycloudStorageAccount.CreateCloudBlobClient();

            CloudBlobContainer container = blobClient.GetContainerReference(CONTAINER);
            CloudBlockBlob cloudBlockBlob = container.GetBlockBlobReference(fileName);

            // provide the file download location below            
            Stream file = File.OpenWrite(path);    
          

            await cloudBlockBlob.DownloadToStreamAsync(file);

            file.Close();
        }

        public static async void DeleteItem(string fileName)
        {
            CloudStorageAccount storage = CloudStorageAccount.Parse(CONNECTION);
            CloudBlobClient blobClient = storage.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference(CONTAINER);

            var blob = container.GetBlockBlobReference(fileName);
            await blob.DeleteIfExistsAsync();
        }
    }
}
