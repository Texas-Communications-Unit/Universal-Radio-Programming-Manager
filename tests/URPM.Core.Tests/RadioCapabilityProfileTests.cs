using TXCOMU.URPM.Core.Capabilities;
using Xunit;

namespace TXCOMU.URPM.Core.Tests;

public sealed class RadioCapabilityProfileTests
{
    [Fact]
    public void UnknownFeature_ReturnsUnknownInsteadOfAssumingSupport()
    {
        var profile = new RadioCapabilityProfile(
            manufacturer: "Example",
            productFamily: "Portable",
            model: "Model A");

        var capability = profile.GetCapability("gps");

        Assert.Equal(CapabilitySupportState.Unknown, capability.State);
    }

    [Fact]
    public void SameModel_CanHaveDifferentFeatureSets()
    {
        var first = new RadioCapabilityProfile(
            manufacturer: "Example",
            productFamily: "Portable",
            model: "Model A",
            firmwareVersion: "1.0");

        var second = new RadioCapabilityProfile(
            manufacturer: "Example",
            productFamily: "Portable",
            model: "Model A",
            firmwareVersion: "2.0");

        first.SetCapability(new FeatureCapability("feature-x", CapabilitySupportState.NotPresent));
        second.SetCapability(new FeatureCapability("feature-x", CapabilitySupportState.Supported));

        Assert.Equal(CapabilitySupportState.NotPresent, first.GetCapability("feature-x").State);
        Assert.Equal(CapabilitySupportState.Supported, second.GetCapability("feature-x").State);
    }

    [Fact]
    public void CapabilityLookup_IsCaseInsensitive()
    {
        var profile = new RadioCapabilityProfile(
            manufacturer: "Example",
            productFamily: "Portable",
            model: "Model A");

        profile.SetCapability(new FeatureCapability("Bluetooth", CapabilitySupportState.Disabled));

        Assert.Equal(
            CapabilitySupportState.Disabled,
            profile.GetCapability("bluetooth").State);
    }
}
