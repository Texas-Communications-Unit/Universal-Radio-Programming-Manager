namespace TXCOMU.URPM.Core.Capabilities;

public sealed record FeatureCapability
{
    public FeatureCapability(string key, CapabilitySupportState state, string? notes = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(key);

        Key = key;
        State = state;
        Notes = notes;
    }

    public string Key { get; }

    public CapabilitySupportState State { get; }

    public string? Notes { get; }

    public static FeatureCapability Unknown(string key) =>
        new(key, CapabilitySupportState.Unknown);
}
