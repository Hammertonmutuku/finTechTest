namespace TechTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string apiUrl = "https://example.com/api/sampleEndpoint";

            try
            {
                // Send GET request and validate response
                string responseData = await GetApiResponse(apiUrl);

                // Process the response data as needed
                Console.WriteLine($"Response from the API: {responseData}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        static async Task<string> GetApiResponse(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                // Send GET request
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                // Check if the request was successful
                response.EnsureSuccessStatusCode();

                // Read and return the response content as a string (assuming JSON data)
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
   
}