var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireCheck_ApiService>("apiservice");

builder.AddProject<Projects.AspireCheck_Web>("webfrontend")
    .WithReference(apiService);

builder.Build().Run();
