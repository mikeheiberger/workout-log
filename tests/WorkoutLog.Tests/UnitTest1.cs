using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;

namespace WorkoutLog.Tests;

public class SmokeTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public SmokeTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task Weatherforecast_endpoint_returns_success()
    {
        var client = _factory.CreateClient();
        var response = await client.GetAsync("/weatherforecast");

        response.IsSuccessStatusCode.Should().BeTrue();
    }
}
