namespace TXCOMU.URPM.Core.Capabilities;

public sealed class RadioCapabilityProfile
{
    private readonly Dictionary<string, FeatureCapability> _capabilities =
        new(StringComparer.OrdinalIgnoreCase);

    public RadioCapabilityProfile(
        string manufacturer,
        string productFamily,
        string model,
        string? hardwareRevision = null,
        string? firmwareVersion = null,
        string? programmingSoftware = null,
        string? programmingSoftwareVersion = null,
        string? bandVariant = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(manufacturer);
        ArgumentException.ThrowIfNullOrWhiteSpace(productFamily);
        ArgumentException.ThrowIfNullOrWhiteSpace(model);

        Manufacturer = manufacturer;
        ProductFamily = productFamily;
        Model = model;
        HardwareRevision = hardwareRevision;
        FirmwareVersion = firmwareVersion;
        ProgrammingSoftware = programmingSoftware;
        ProgrammingSoftwareVersion = programmingSoftwareVersion;
        BandVariant = bandVariant;
    }

    public string Manufacturer { get; }

    public string ProductFamily { get; }

    public string Model { get; }

    public string? HardwareRevision { get; }

    public string? FirmwareVersion { get; }

    public string? ProgrammingSoftware { get; }

    public string? ProgrammingSoftwareVersion { get; }

    public string? BandVariant { get; }

    public IReadOnlyDictionary<string, FeatureCapability> Capabilities => _capabilities;

    public void SetCapability(FeatureCapability capability)
    {
        ArgumentNullException.ThrowIfNull(capability);
        _capabilities[capability.Key] = capability;
    }

    public FeatureCapability GetCapability(string key)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(key);

        return _capabilities.TryGetValue(key, out var capability)
            ? capability
            : FeatureCapability.Unknown(key);
    }
}
