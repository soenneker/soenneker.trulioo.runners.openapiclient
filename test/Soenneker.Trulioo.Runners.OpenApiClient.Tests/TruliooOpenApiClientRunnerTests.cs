using Soenneker.Tests.HostedUnit;

namespace Soenneker.Trulioo.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class TruliooOpenApiClientRunnerTests : HostedUnitTest
{
    public TruliooOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
