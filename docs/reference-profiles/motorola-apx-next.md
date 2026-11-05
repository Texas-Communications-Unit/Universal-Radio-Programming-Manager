# Motorola APX/NEXT Canonical Reference Profile

This document implements the repository-facing portion of GitHub issue #30 and is subordinate to the [Reference Codeplug Research Standard](../reference-codeplug-standard.md).

## Purpose

This profile will define the first exact, reproducible Motorola reference configuration used by the TX-COMU Universal Radio Programming Manager (URPM) project.

The values in this document must be synthetic, non-operational, and suitable for public reproduction by contributors.

Until values are approved, fields remain marked **TBD**. Do not substitute real agency, incident, subscriber, system, or cryptographic data.

## Profile status

- Profile version: `0.1-draft`
- Status: **Awaiting controlled values**
- Source: Known-good Motorola APX/NEXT test configuration supplied for URPM testing
- Related issue: #30
- Capability model: #26
- Motorola research: #24
- Motorola integration planning: #19

## Radio / programming environment

| Item | Controlled value |
| --- | --- |
| Manufacturer | Motorola Solutions |
| Product family | TBD |
| Exact model | TBD |
| Hardware revision | TBD |
| Firmware version | TBD |
| Programming software | TBD |
| Programming software version | TBD |
| Band / range variant | TBD |
| Installed / licensed options relevant to sample | TBD |
| Native file / export format | TBD |

## Reference Profile A — Conventional

| Field | Controlled value |
| --- | --- |
| Zone name | TBD |
| Channel name | TBD |
| Channel type | TBD |
| RX frequency | TBD |
| TX frequency | TBD |
| RX squelch type | TBD |
| RX squelch value | TBD |
| TX squelch type | TBD |
| TX squelch value | TBD |
| NAC, if applicable | TBD |
| Channel spacing / bandwidth | TBD |
| Transmit power | TBD |
| Direct / talkaround state | TBD |
| Scan state | TBD |
| Secure / clear state | TBD |
| Emergency behavior | TBD |
| Required automatically-created Motorola objects/defaults | TBD |

## Reference Profile B — P25 Trunked

| Field | Controlled value |
| --- | --- |
| System alias | TBD |
| WACN | TBD |
| System ID | TBD |
| RFSS ID, if required | TBD |
| Site ID, if required | TBD |
| Site alias | TBD |
| Control-channel / site data required by software | TBD |
| Talkgroup alias | TBD |
| Talkgroup ID | TBD |
| Zone name | TBD |
| Channel position / name | TBD |
| Synthetic radio ID, if required | TBD |
| Secure / clear state | TBD |
| Scan state | TBD |
| Emergency behavior | TBD |
| Roaming / multi-site state | TBD |
| Required automatically-created Motorola objects/defaults | TBD |

## Model- and feature-specific notes

Use this section to document behavior that is specific to the exact radio, firmware, software version, or installed feature set.

Examples include:

- a field the software adds automatically;
- a feature unavailable on this exact radio;
- a setting represented differently between APX and APX NEXT;
- firmware-dependent behavior;
- option-dependent fields;
- values the software normalizes or rewrites on save.

Do not interpret a missing field as proof that all radios of the same model lack that capability.

## Baseline files

Public baseline files may be added only after sanitization and redistribution review.

| File | Type | Model / firmware / software | Status |
| --- | --- | --- | --- |
| TBD | TBD | TBD | Awaiting controlled baseline |

## Differential variants

After the baseline is validated, create one-variable variants where exactly one setting changes.

Recommended first variants:

1. Channel display name only.
2. RX frequency only.
3. TX frequency only.
4. Squelch / NAC setting only.
5. Transmit power only.
6. Talkgroup ID only.
7. Scan membership only.
8. One additional zone/channel only.
9. One optional feature only.
10. Identical configuration saved a second time.

Each variant must document the single intentional change and all model/firmware/software metadata.

## Public contribution requirements

Contributors reproducing this profile must provide:

- manufacturer;
- product family;
- exact model;
- hardware revision, if known;
- firmware version;
- programming software and version;
- band / variant;
- relevant installed/licensed feature options;
- native file format;
- whether the file was exported, saved, or read from a radio;
- any setting the target platform could not represent;
- any defaults or extra records the software created automatically.

Use the **Reference Codeplug Sample** GitHub issue form before proposing a fixture for the repository.

## Prohibited content

Do not commit or submit:

- operational incident codeplugs;
- real public-safety system identifiers;
- real subscriber/radio identifiers;
- encryption keys or key-management material;
- credentials or certificates;
- real agency-sensitive configuration data;
- proprietary manufacturer software or restricted documentation.

## Approval checklist

- [ ] Controlled values supplied from the approved test configuration.
- [ ] Values reviewed as synthetic/non-operational.
- [ ] Conventional profile reproduced successfully.
- [ ] P25 trunked profile reproduced successfully.
- [ ] Model/firmware/software metadata recorded.
- [ ] Automatic/default Motorola-created records documented.
- [ ] Baseline fixture reviewed for public release.
- [ ] Differential-test sequence approved.
