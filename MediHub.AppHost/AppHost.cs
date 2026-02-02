var builder = DistributedApplication.CreateBuilder(args);
// lets add our app and api as projects

var api = builder.AddProject<Projects.MediHub_API>("medihub-api");

builder.AddProject<Projects.MediHub_App>("medihub-app")
    .WithReference(api)
    .WaitFor(api);

builder.Build().Run();
