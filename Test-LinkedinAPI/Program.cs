using DotNetEnv;
using System.Net.Http.Headers;

// Load .env from project root
var projectRoot = FindProjectRoot();
Env.Load(Path.Combine(projectRoot, ".env"));

var dsn = Environment.GetEnvironmentVariable("UNIPILE_DSN")?.TrimEnd('/');
var apiKey = Environment.GetEnvironmentVariable("UNIPILE_API_KEY");

Console.WriteLine($"Testing connection to: {dsn}");

using var http = new HttpClient();
http.DefaultRequestHeaders.Add("X-API-KEY", apiKey);

try
{
    var response = await http.GetAsync($"{dsn}/api/v1/accounts");
    var body = await response.Content.ReadAsStringAsync();

    if (response.IsSuccessStatusCode)
    {
        Console.WriteLine("API key is VALID");
        Console.WriteLine($"Response: {body}");
    }
    else
    {
        Console.WriteLine($"API key is INVALID (HTTP {response.StatusCode})");
        Console.WriteLine($"Response: {body}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Connection failed: {ex.Message}");
}

static string FindProjectRoot()
{
    var dir = new DirectoryInfo(AppContext.BaseDirectory);
    while (dir != null && dir.GetFiles("*.csproj").Length == 0)
        dir = dir.Parent;
    return dir?.FullName ?? Directory.GetCurrentDirectory();
}