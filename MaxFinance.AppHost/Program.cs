var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.MaxFinance_Api>("api");

builder.AddProject<Projects.MaxFinance_Web>("web")
    .WithReference(apiService);

builder.Build().Run();
