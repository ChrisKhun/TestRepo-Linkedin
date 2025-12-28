// ============================================================================
// Unipile API Connection Test
// Author: Christopher Khun
// Date: 12/17/25
//
// Description:
// Tests connection to Unipile API and retrieves connected account details.
// Loads credentials through API from .env file
// ============================================================================
using DotNetEnv;
using Test_LinkedinAPI;
using Test_LinkedinAPI.Services;

//// load envirnoment vars
//static string FindProjectRoot()
//{
//    var dir = new DirectoryInfo(AppContext.BaseDirectory);
//    while (dir != null && dir.GetFiles("*.csproj").Length == 0)
//        dir = dir.Parent;
//    return dir?.FullName ?? Directory.GetCurrentDirectory();
//}

//var projectRoot = FindProjectRoot();
//var envPath = Path.Combine(projectRoot, ".env");

//Console.WriteLine($"Looking for .env at: {envPath}");
//Console.WriteLine($"File exists: {File.Exists(envPath)}");

//if (!File.Exists(envPath))
//{
//    Console.WriteLine($"\nERROR: .env file not found!");
//    Console.WriteLine($"Current directory: {Directory.GetCurrentDirectory()}");
//    Console.WriteLine($"Project root: {projectRoot}");
//    return;
//}

//Env.Load(envPath);
//Console.WriteLine(".env loaded successfully\n");

var dsn = Environment.GetEnvironmentVariable("UNIPILE_DSN");
var apiKey = Environment.GetEnvironmentVariable("UNIPILE_API_KEY");
var accountId = Environment.GetEnvironmentVariable("UNIPILE_ACCOUNT_ID");

//// validate info
//if (string.IsNullOrWhiteSpace(dsn) || string.IsNullOrWhiteSpace(apiKey) || string.IsNullOrWhiteSpace(accountId))
//{
//    Console.WriteLine("ERROR: Missing credentials in .env file");
//    Console.WriteLine("Required: UNIPILE_DSN, UNIPILE_API_KEY, UNIPILE_ACCOUNT_ID");
//    return;
//}

//Console.WriteLine("===========================================");
//Console.WriteLine("LinkedIn Employee Contact Search Tool");
//Console.WriteLine("===========================================\n");

//// create API client
//using var client = new UnipileService(dsn, apiKey, accountId);

//// test connection
//Console.WriteLine("Testing API connection...");
//if (!await client.TestConnectionAsync())
//{
//    Console.WriteLine("\nConnection failed. Please check your credentials.");
//    return;
//}

//Console.WriteLine();

//// get company name
//Console.Write("Enter company name: ");
//var company = Console.ReadLine();

//if (string.IsNullOrWhiteSpace(company))
//{ 
//    Console.WriteLine("No company entered. Exiting.");
//    return;
//}

//// Run the search
//await client.SearchEmployeesByCompanyNameAsync(company);

//Console.WriteLine("\nStarting search...\n");
//Console.WriteLine("\nSearch complete. Press any key to exit.");
//Console.ReadKey();

var svc = new UnipileService(dsn, apiKey, accountId);

var linkedInProfiles = await svc.GetEmployeesByCompanyKeywordsAsync("pharamcutical", "marketing");

if(linkedInProfiles.Count() > 0)
{
    var filepath = "";
    await svc.ExportProfilesToCsvAsync(linkedInProfiles, "LinkedInSearch.csv");
}
