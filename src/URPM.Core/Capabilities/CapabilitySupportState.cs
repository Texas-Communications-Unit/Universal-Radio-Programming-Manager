namespace TXCOMU.URPM.Core.Capabilities;

public enum CapabilitySupportState
{
    Unknown = 0,
    Supported = 1,
    Unsupported = 2,
    NotPresent = 3,
    Disabled = 4,
    FirmwareDependent = 5,
    ReadOnly = 6,
    ImportExportOnly = 7,
    DirectProgramming = 8
}
