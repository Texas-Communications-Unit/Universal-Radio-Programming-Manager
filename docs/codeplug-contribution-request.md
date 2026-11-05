# Codeplug Contribution Request

Texas Communications Unit (TX-COMU) is collecting **synthetic, reproducible test codeplugs** to support development of the Universal Radio Programming Manager (URPM).

The goal is simple: have contributors build the **same logical programming** in different manufacturers, radio families, models, firmware versions, and programming applications so we can compare how each platform stores and represents the same information.

## What we want you to build

Build a test codeplug that matches the following structure as closely as your radio and programming software allow.

### Trunked zones

Create four trunked zones with 16 channel positions each:

#### Zone 1 — `DEPLOY YY`

1. `CALL YY`
2. `CMD YY`
3. `TAC YY3`
4. `TAC YY4`
5. `TAC YY5`
6. `TAC YY6`
7. `TAC YY7`
8. `TAC YY8`
9. `TAC YY9`
10. `TAC YY10`
11. `TAC YY11`
12. `TAC YY12`
13. `TAC YY13`
14. `TAC YY14`
15. `TAC YY15`
16. `EMER YY`

#### Zone 2 — `DEPLOY ZZ`

1. `CALL ZZ`
2. `CMD ZZ`
3. `TAC ZZ3`
4. `TAC ZZ4`
5. `TAC ZZ5`
6. `TAC ZZ6`
7. `TAC ZZ7`
8. `TAC ZZ8`
9. `TAC ZZ9`
10. `TAC ZZ10`
11. `TAC ZZ11`
12. `TAC ZZ12`
13. `TAC ZZ13`
14. `TAC ZZ14`
15. `TAC ZZ15`
16. `EMER ZZ`

#### Zone 3 — `DEPLOY YY*`

Use the same underlying trunked talkgroup references as Zone 1 where the radio/software permits, but use these display names:

1. `CALL YY*`
2. `CMD YY*`
3. `TAC YY3*`
4. `TAC YY4*`
5. `TAC YY5*`
6. `TAC YY6*`
7. `TAC YY7*`
8. `TAC YY8*`
9. `TAC YY9*`
10. `TAC YY10*`
11. `TAC YY11*`
12. `TAC YY12*`
13. `TAC YY13*`
14. `TAC YY14*`
15. `TAC YY15*`
16. `EMER YY*`

#### Zone 4 — `DEPLOY ZZ*`

Use the same underlying trunked talkgroup references as Zone 2 where the radio/software permits, but use these display names:

1. `CALL ZZ*`
2. `CMD ZZ*`
3. `TAC ZZ3*`
4. `TAC ZZ4*`
5. `TAC ZZ5*`
6. `TAC ZZ6*`
7. `TAC ZZ7*`
8. `TAC ZZ8*`
9. `TAC ZZ9*`
10. `TAC ZZ10*`
11. `TAC ZZ11*`
12. `TAC ZZ12*`
13. `TAC ZZ13*`
14. `TAC ZZ14*`
15. `TAC ZZ15*`
16. `EMER ZZ*`

### P25 trunked system values

The exact synthetic values for WACN, System ID, RFSS/Site IDs, talkgroup IDs, subscriber/radio ID, and related trunked-system settings are **not yet published**.

Do not substitute operational agency or incident values.

TX-COMU will add the approved synthetic trunked-system value set to this document once it has been validated across programming applications.

## Conventional zone

Create one conventional zone named:

`800 I/O`

Use one conventional personality named:

`800 INTEROP`

Program the following 13 channels:

| Position | Channel | RX MHz | TX MHz | TX tone | RX squelch |
| ---: | --- | ---: | ---: | --- | --- |
| 1 | `8CALL90` | 851.012500 | 806.012500 | PL 156.7 Hz | CSQ |
| 2 | `8CALL90D` | 851.012500 | 851.012500 | PL 156.7 Hz | CSQ |
| 3 | `8TAC91` | 851.512500 | 806.512500 | PL 156.7 Hz | CSQ |
| 4 | `8TAC91D` | 851.512500 | 851.512500 | PL 156.7 Hz | CSQ |
| 5 | `8TAC92` | 852.012500 | 807.012500 | PL 156.7 Hz | CSQ |
| 6 | `8TAC92D` | 852.012500 | 852.012500 | PL 156.7 Hz | CSQ |
| 7 | `8TAC93` | 852.512500 | 807.512500 | PL 156.7 Hz | CSQ |
| 8 | `8TAC93D` | 852.512500 | 852.512500 | PL 156.7 Hz | CSQ |
| 9 | `8TAC94` | 853.012500 | 808.012500 | PL 156.7 Hz | CSQ |
| 10 | `8TAC94D` | 853.012500 | 853.012500 | PL 156.7 Hz | CSQ |
| 11 | `8TAC95D` | 851.550000 | 851.550000 | PL 156.7 Hz | CSQ |
| 12 | `8TAC96D` | 853.050000 | 853.050000 | PL 156.7 Hz | CSQ |
| 13 | `8TAC97D` | 853.350000 | 853.350000 | PL 156.7 Hz | CSQ |

These values come from the verified Motorola APX8500/APX NEXT CPS 39 comparison already documented in this repository.

The `D` suffix is part of the reference channel name. Do not infer authorization, coverage, or operating purpose from the label.

## General programming settings

Where the platform permits, use the following baseline behavior:

- clear voice only;
- encryption disabled;
- OTAR/OTAP disabled unless the programming software requires an object to exist;
- scan disabled unless required;
- emergency features disabled unless required for a valid codeplug;
- GPS, Wi-Fi, Bluetooth, LTE, data, and other optional features disabled unless required;
- roaming/multi-site behavior disabled unless required;
- use default power/bandwidth values only when no explicit reference value has been published;
- preserve any records or defaults the programming application creates automatically.

Do **not** remove manufacturer-required defaults just to make the file look like another manufacturer's file.

## Tell us exactly what you used

Every submitted sample should include:

- manufacturer;
- product family;
- exact model number;
- hardware revision, if known;
- firmware version;
- programming software and version;
- band/range variant;
- installed or licensed feature options relevant to the sample;
- native file type or extension;
- whether the file was saved/exported from software or read from a radio;
- anything the software added automatically;
- anything in this reference that the radio/software could not represent.

If two radios have the same model number but different firmware or feature options, we want to know that.

## What not to send

Do not submit:

- operational agency codeplugs;
- incident-derived codeplugs;
- real P25 system identifiers;
- real subscriber/radio IDs;
- real talkgroup IDs unless they are part of an explicitly approved synthetic reference set;
- encryption keys or key-management material;
- credentials or certificates;
- sensitive network information;
- proprietary manufacturer software or restricted documentation.

This research library is intended to remain safe for public development and testing.

## How to contribute

1. Review the [Reference Codeplug Research Standard](reference-codeplug-standard.md).
2. Build the reference configuration as closely as your platform allows.
3. Record your model, firmware, software version, and feature-option metadata.
4. Use the repository's **Reference Codeplug Sample** GitHub issue form to describe the sample.
5. Do not upload the codeplug publicly until sanitization and redistribution rights have been reviewed.

## Why this matters

A Motorola, L3Harris, JVCKENWOOD, BK Technologies, Tait, or other radio may represent the same logical programming very differently. Even two radios with the same model number may differ because of firmware, hardware revision, or licensed features.

Comparable samples let URPM learn those differences instead of assuming one manufacturer's structure applies to another.
