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

    [Fact]
    public void L3Harris_XL200P_Profile_EvaluatesCapabilitiesCorrectly()
    {
        var profile = new RadioCapabilityProfile(
            manufacturer: "L3Harris",
            productFamily: "XL Series",
            model: "XL-200P",
            hardwareRevision: "Rev 1",
            firmwareVersion: "R06A02",
            programmingSoftware: "RPM2",
            programmingSoftwareVersion: "R14B05",
            bandVariant: "All-Band (VHF/UHF/700/800)");

        profile.SetCapability(new FeatureCapability("p25-phase1", CapabilitySupportState.Supported));
        profile.SetCapability(new FeatureCapability("p25-phase2", CapabilitySupportState.Supported));
        profile.SetCapability(new FeatureCapability("multiband", CapabilitySupportState.Supported));
        profile.SetCapability(new FeatureCapability("lte", CapabilitySupportState.Supported));
        profile.SetCapability(new FeatureCapability("gps", CapabilitySupportState.Supported));
        profile.SetCapability(new FeatureCapability("bluetooth", CapabilitySupportState.Supported));
        profile.SetCapability(new FeatureCapability("edacs-provoice", CapabilitySupportState.Disabled));
        profile.SetCapability(new FeatureCapability("fips-aes256", CapabilitySupportState.Supported));

        Assert.Equal("L3Harris", profile.Manufacturer);
        Assert.Equal("XL-200P", profile.Model);
        Assert.Equal("RPM2", profile.ProgrammingSoftware);
        Assert.Equal(CapabilitySupportState.Supported, profile.GetCapability("p25-phase2").State);
        Assert.Equal(CapabilitySupportState.Supported, profile.GetCapability("P25-PHASE2").State);
        Assert.Equal(CapabilitySupportState.Disabled, profile.GetCapability("edacs-provoice").State);
        Assert.Equal(CapabilitySupportState.Unknown, profile.GetCapability("unconfigured-feature").State);
    }
}
