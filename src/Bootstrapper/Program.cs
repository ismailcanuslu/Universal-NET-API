using Auditing.Api.Endpoints;
using Auditing.Application;
using Auditing.Infrastructure;
using BuildingBlocks.Api;
using Files.Api.Endpoints;
using Files.Application;
using Files.Infrastructure;
using Messaging.Api.Endpoints;
using Messaging.Application;
using Messaging.Infrastructure;
using Notifications.Api.Endpoints;
using Notifications.Application;
using Notifications.Infrastructure;
using Scheduling.Api.Endpoints;
using Scheduling.Application;
using Scheduling.Infrastructure;
using Security.Api.Endpoints;
using Security.Application;
using Security.Infrastructure;
using Translations.Api.Endpoints;
using Translations.Application;
using Translations.Infrastructure;
using ImportExport.Api.Endpoints;
using ImportExport.Application;
using ImportExport.Infrastructure;
using Webhooks.Api.Endpoints;
using Webhooks.Application;
using Webhooks.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// BuildingBlocks
builder.Services.AddBuildingBlocksApi(builder.Configuration);

// Security Module
builder.Services.AddSecurityApplication();
var securityConnectionString = builder.Configuration.GetConnectionString("SecurityDatabase")
    ?? "Server=localhost;Database=obs_security;Trusted_Connection=True;TrustServerCertificate=True;";
builder.Services.AddSecurityInfrastructure(builder.Configuration, securityConnectionString);

// Files Module
builder.Services.AddFilesApplication();
var filesConnectionString = builder.Configuration.GetConnectionString("FilesDatabase")
    ?? "Server=localhost;Database=obs_files;Trusted_Connection=True;TrustServerCertificate=True;";
builder.Services.AddFilesInfrastructure(builder.Configuration, filesConnectionString);

// Notifications Module
builder.Services.AddNotificationsApplication();
var notificationsConnectionString = builder.Configuration.GetConnectionString("NotificationsDatabase")
    ?? "Server=localhost;Database=obs_notifications;Trusted_Connection=True;TrustServerCertificate=True;";
builder.Services.AddNotificationsInfrastructure(builder.Configuration, notificationsConnectionString);

// Translations Module
builder.Services.AddTranslationsApplication();
builder.Services.AddTranslationsInfrastructure();

// Auditing Module
builder.Services.AddAuditingApplication();
var auditingConnectionString = builder.Configuration.GetConnectionString("AuditingDatabase")
    ?? builder.Configuration.GetConnectionString("AuditingDb")
    ?? "Server=localhost;Database=obs_auditing;Trusted_Connection=True;TrustServerCertificate=True;";
builder.Services.AddAuditingInfrastructure(builder.Configuration, auditingConnectionString);

// Messaging Module
builder.Services.AddMessagingApplication();
var messagingConnectionString = builder.Configuration.GetConnectionString("MessagingDatabase")
    ?? builder.Configuration.GetConnectionString("MessagingDb")
    ?? "Server=localhost;Database=obs_messaging;Trusted_Connection=True;TrustServerCertificate=True;";
builder.Services.AddMessagingInfrastructure(builder.Configuration, messagingConnectionString);

// Scheduling Module
builder.Services.AddSchedulingApplication();
var schedulingConnectionString = builder.Configuration.GetConnectionString("SchedulingDatabase")
    ?? builder.Configuration.GetConnectionString("SchedulingDb")
    ?? "Server=localhost;Database=obs_scheduling;Trusted_Connection=True;TrustServerCertificate=True;";
builder.Services.AddSchedulingInfrastructure(builder.Configuration, schedulingConnectionString);

// Webhooks Module
builder.Services.AddWebhooksApplication();
var webhooksConnectionString = builder.Configuration.GetConnectionString("WebhooksDatabase")
    ?? builder.Configuration.GetConnectionString("WebhooksDb")
    ?? "Server=localhost;Database=obs_webhooks;Trusted_Connection=True;TrustServerCertificate=True;";
builder.Services.AddWebhooksInfrastructure(builder.Configuration, webhooksConnectionString);

// Import / Export Module
builder.Services.AddImportExportApplication();
builder.Services.AddImportExportInfrastructure();

builder.Services.AddOpenApi();

var app = builder.Build();

app.UseBuildingBlocksApi();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapBuildingBlocksApi();
app.MapSecurityEndpoints();
app.MapFilesEndpoints();
app.MapNotificationsEndpoints();
app.MapTranslationEndpoints();
app.MapAuditLogEndpoints();
app.MapMessagingEndpoints();
app.MapSchedulingEndpoints();
app.MapWebhooksEndpoints();
app.MapImportExportEndpoints();

app.Run();
