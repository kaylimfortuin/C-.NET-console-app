namespace AdventureWorksDatabase
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            // Entry point into Cosmos DB
            string endpoint = "https://youraccount.documents.azure.com:443/";
            string key = "your-primary-key";
            CosmosClient client = new CosmosClient(endpoint, key);

            // Get or create a database
            Database database = await client.CreateDatabaseIfNotExistsAsync("adventureworks-1");

            // Set throughput to the minimum value of 400 RU/s
            ContainerResponse simpleContainer = await database.CreateContainerIfNotExistsAsync(
                id: containerId,
                partitionKeyPath: partitionKey,
                throughput: 400);

            //create a item
            ItemResponse<SalesOrder> response = await container.CreateItemAsync(salesOrder, new PartitionKey(salesOrder.AccountNumber));

            // Check if the item was created successfully
            string id = "[id]";
            string accountNumber = "[partition-key]";
            ItemResponse<SalesOrder> response = await container.ReadItemAsync(id, new PartitionKey(accountNumber));

            // Read database metadata
            DatabaseResponse readResponse = await database.ReadAsync();

            if (readResponse.StatusCode == HttpStatusCode.OK)
            {
                Console.WriteLine($"Database ID: {readResponse.Database.Id}");
                Console.WriteLine($"Request Charge: {readResponse.RequestCharge} RUs");
            }
            else
            {
                Console.WriteLine($"Failed to read database. Status Code: {readResponse.StatusCode}");
            }
        }
    }
}
// This code connects to an Azure Cosmos DB account, creates a database if it doesn't exist,
// and reads the database metadata. It prints the database ID and request charge to the console.
// Make sure to replace "youraccount" and "your-primary-key" with your actual Cosmos DB account name and primary key.