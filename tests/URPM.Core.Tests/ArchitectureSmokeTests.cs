using TXCOMU.URPM.Core;
using Xunit;

namespace TXCOMU.URPM.Core.Tests;

public sealed class ArchitectureSmokeTests
{
    [Fact]
    public void CoreAssembly_CanBeLoaded()
    {
        var assembly = typeof(AssemblyMarker).Assembly;

        Assert.Equal("TXCOMU.URPM.Core", assembly.GetName().Name);
    }
}
