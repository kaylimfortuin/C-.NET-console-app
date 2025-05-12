using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Azure.Storage.Blobs;
 
namespace FunctionApp
{
    public static class StoreUserDataFunction
    {
        [FunctionName("StoreUserData")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Processing user data submission.");
 
            try
            {
                // Read the request body
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                if (string.IsNullOrEmpty(requestBody))
                {
                    return new BadRequestObjectResult("Request body is empty.");
                }
 
                // Deserialize JSON to a UserData object
                UserData userData = JsonConvert.DeserializeObject<UserData>(requestBody);
                if (string.IsNullOrEmpty(userData?.Name) || string.IsNullOrEmpty(userData?.Email))
                {
                    return new BadRequestObjectResult("Name and email are required.");
                }
 
                // Validate email format (basic check)
                if (!userData.Email.Contains("@"))
                {
                    return new BadRequestObjectResult("Invalid email format.");
                }
 
                // Initialize Blob Service Client (using connection string from configuration)
                string connectionString = Environment.GetEnvironmentVariable("StorageConnectionString");
                var blobServiceClient = new BlobServiceClient(connectionString);
                var containerClient = blobServiceClient.GetBlobContainerClient("user-data");
 
                // Ensure the container exists
                await containerClient.CreateIfNotExistsAsync();
 
                // Generate a unique blob name (e.g., user_<guid>.json)
                string blobName = $"user_{Guid.NewGuid().ToString()}.json";
                var blobClient = containerClient.GetBlobClient(blobName);
 
                // Serialize the user data to JSON and upload to Blob Storage
                string jsonData = JsonConvert.SerializeObject(userData);
                using (var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(jsonData)))
                {
                    await blobClient.UploadAsync(stream, overwrite: true);
                }
 
                log.LogInformation($"Successfully stored data for {userData.Name} in blob {blobName}.");
                return new OkObjectResult($"User data for {userData.Name} stored successfully.");
            }
            catch (Exception ex)
            {
                log.LogError($"Error processing request: {ex.Message}");
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }
 
        // Class to represent the expected JSON payload
        public class UserData
        {
            public string Name { get; set; }
            public string Email { get; set; }
        }
    }
}