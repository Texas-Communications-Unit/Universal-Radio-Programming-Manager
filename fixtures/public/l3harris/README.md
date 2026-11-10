# L3Harris Public Test Fixtures

This directory contains public, reviewed test fixtures for L3Harris radio programming used by the TX-COMU Universal Radio Programming Manager (URPM) project.

All files committed here must be **synthetic, sanitized, and non-operational**.

## Directory layout

```text
fixtures/public/l3harris/
  xl200p/
    README.md
    synthetic-template.xml
  xg100m/
    README.md
```

## Contribution standards

Each fixture must adhere to the [Reference Codeplug Research Standard](../../../docs/reference-codeplug-standard.md):

- Include the sanitized configuration file (`.rpm2` or exported XML);
- Document the programming software version (e.g. RPM2 R14B);
- Document target radio family and hardware revision;
- Provide SHA-256 integrity checksums;
- Never include real operational IDs, frequencies, talkgroups, or cryptographic keys.

## Research use

Use these files exclusively for read-only format analysis, field mapping, import/export validation, and capability checking.
