# Reference Codeplug Research Standard

This document supports GitHub issue #27 and defines the first repository-level standard for collecting sanitized, comparable radio-programming samples.

## Purpose

Random real-world codeplugs are useful, but controlled samples are substantially more valuable for identifying file structures and manufacturer-specific mappings.

TX-COMU will maintain two canonical logical profiles:

1. **Reference Profile A — Conventional**
2. **Reference Profile B — P25 Trunked**

Contributors should reproduce the applicable profile as closely as their radio model, firmware, licensed options, and programming software allow.

## Model and feature awareness

A submitted file must never be treated as representative of an entire manufacturer or model family.

Each sample must be associated with:

- manufacturer;
- product family;
- exact model;
- hardware revision, if known;
- firmware version;
- programming software and version;
- band/region variant where relevant;
- installed or licensed feature options where known;
- file type and method used to create the file.

An absent field means only that the field is absent from that sample. It does not prove the radio or model lacks the feature.

See issue #26 for the capability-profile architecture.

## Profile A — Conventional

The target logical configuration is deliberately minimal:

- one zone;
- one conventional channel;
- one channel display label;
- explicit RX and TX frequency fields where supported;
- explicit squelch/signaling selection where supported;
- explicit channel spacing/bandwidth where supported;
- explicit transmit-power selection where supported;
- explicit direct/talkaround state where supported;
- scan disabled unless the radio requires otherwise;
- secure/encryption features disabled;
- OTAR/OTAP disabled;
- optional data/location/wireless features disabled unless required by the platform.

If the radio automatically adds required defaults or related records, document them instead of deleting them.

## Profile B — P25 Trunked

The target logical configuration is the smallest valid P25 trunked configuration the radio and programming software can create:

- one trunked system;
- one site when required;
- one talkgroup;
- one zone;
- one channel position referencing that talkgroup;
- clear voice only;
- secure/encryption features disabled;
- OTAR disabled;
- scan disabled unless required;
- emergency features disabled unless required;
- optional data/location/wireless features disabled unless required;
- roaming and multi-site behavior disabled unless required for validity.

## Controlled values

A separate controlled-value sheet will be adopted only after the values are verified to be:

- synthetic and non-operational;
- accepted by the relevant programming applications;
- unsuitable for accidental field use;
- consistent enough to compare across manufacturers.

Until that sheet is approved, contributors should not invent their own public sample values for repository fixtures.

## One-variable differential samples

After creating a baseline sample, a contributor may create variants in which exactly one setting changes.

Preferred variants include:

1. channel or talkgroup display label;
2. RX frequency;
3. TX frequency;
4. squelch or NAC-related setting;
5. transmit power;
6. talkgroup identifier;
7. scan membership;
8. addition of one zone/channel;
9. one optional feature;
10. a second save of the identical configuration.

Each variant must document exactly what changed.

## Public repository rules

Do not commit:

- incident-derived codeplugs;
- operational frequencies or system identifiers;
- real subscriber/radio identifiers;
- encryption keys or key-management material;
- credentials or certificates;
- proprietary manufacturer software or documentation;
- files whose redistribution rights are unclear.

Only synthetic or fully sanitized fixtures may be committed.

## Submission workflow

Use the GitHub issue form **Reference Codeplug Sample** to document a candidate file before adding it to the repository.

A sample should not become a public fixture until it has been reviewed for:

- sanitization;
- model/firmware metadata;
- feature-option metadata;
- redistribution rights;
- consistency with this standard.
