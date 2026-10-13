using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace BuildingBlocks.Api.Idempotency;

public static class IdempotencyExtensions
{
    public static IServiceCollection AddBuildingBlocksIdempotency(
        this IServiceCollection services)
    {
        return services;
    }

    public static IApplicationBuilder UseBuildingBlocksIdempotency(
        this IApplicationBuilder app)
    {
        return app.UseMiddleware<IdempotencyMiddleware>();
    }
}