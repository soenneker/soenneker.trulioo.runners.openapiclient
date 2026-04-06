using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Trulioo.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class TruliooOpenApiClientRunnerTests : FixturedUnitTest
{
    public TruliooOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
