# APX8500 vs APX NEXT — CPS 39 channel lineup comparison

**Source:** User-supplied Motorola APX CPS 39 XML exports from an APX8500 mobile and APX NEXT portable. Document date: 2026-11-05.

**Scope:** Extracted zone/channel display assignments and conventional frequency options, **not** a validated device programming file. Both files declare XML document version `2`. This report deliberately omits serial numbers, radio IDs, system identifiers, certificates, encryption references, network addresses and other unrelated configuration.

## Summary

| Property | APX8500 | APX NEXT | Comparison |
| --- | ---: | ---: | --- |
| Zones | 5 | 5 | Equal |
| Trunked zone channel assignments | 64 | 64 | Equal |
| Conventional zone channel assignments | 13 | 13 | Equal |
| All zone channel assignments | 77 | 77 | Equal |
| Ordered zone/channel labels | 77 | 77 | Equal |
| Channel type/personality and assignment target references | 77 | 77 | Equal |
| Conventional RX/TX frequencies | 13 | 13 | Equal |
| Conventional TX PL, RX squelch types | 13 | 13 | Equal |
| All conventional frequency option fields | — | — | **Not equal** |

All 77 zone channel assignments match in ordered reference key, channel name, type (`Trk` or `Cnv`), personality, target talkgroup or frequency-option reference and active-channel status. This equality is for **selected fields only**.

## Trunked zone channel lineup

The following four zones contain 16 ordered `Trk` assignments each. Entries match between the two radio XMLs; no numeric talkgroup IDs or trunking-system metadata are published here.

### Zone `1-DEPLOY YY` (personality references as exported)

| Position | Display channel | Trunking talkgroup reference | Personality reference |
| ---: | --- | --- | --- |
| 1 | `CALL YY` | `CALL YY` | `DEPLOY YY` |
| 2 | `CMD YY` | `CMD YY` | `DEPLOY YY` |
| 3 | `TAC YY3` | `TAC YY3` | `DEPLOY YY` |
| 4 | `TAC YY4` | `TAC YY4` | `DEPLOY YY` |
| 5 | `TAC YY5` | `TAC YY5` | `DEPLOY YY` |
| 6 | `TAC YY6` | `TAC YY6` | `DEPLOY YY` |
| 7 | `TAC YY7` | `TAC YY7` | `DEPLOY YY` |
| 8 | `TAC YY8` | `TAC YY8` | `DEPLOY YY` |
| 9 | `TAC YY9` | `TAC YY9` | `DEPLOY YY` |
| 10 | `TAC YY10` | `TAC YY10` | `DEPLOY YY` |
| 11 | `TAC YY11` | `TAC YY11` | `DEPLOY YY` |
| 12 | `TAC YY12` | `TAC YY12` | `DEPLOY YY` |
| 13 | `TAC YY13` | `TAC YY13` | `DEPLOY YY` |
| 14 | `TAC YY14` | `TAC YY14` | `DEPLOY YY` |
| 15 | `TAC YY15` | `TAC YY15` | `DEPLOY YY` |
| 16 | `EMER YY` | `EMER YY` | `DEPLOY YY` |

### Zone `2-DEPLOY ZZ` (personality references as exported)

| Position | Display channel | Trunking talkgroup reference | Personality reference |
| ---: | --- | --- | --- |
| 1 | `CALL ZZ` | `CALL ZZ` | `DEPLOY ZZ` |
| 2 | `CMD ZZ` | `CMD ZZ` | `DEPLOY ZZ` |
| 3 | `TAC ZZ3` | `TAC ZZ3` | `DEPLOY ZZ` |
| 4 | `TAC ZZ4` | `TAC ZZ4` | `DEPLOY ZZ` |
| 5 | `TAC ZZ5` | `TAC ZZ5` | `DEPLOY ZZ` |
| 6 | `TAC ZZ6` | `TAC ZZ6` | `DEPLOY ZZ` |
| 7 | `TAC ZZ7` | `TAC ZZ7` | `DEPLOY ZZ` |
| 8 | `TAC ZZ8` | `TAC ZZ8` | `DEPLOY ZZ` |
| 9 | `TAC ZZ9` | `TAC ZZ9` | `DEPLOY ZZ` |
| 10 | `TAC ZZ10` | `TAC ZZ10` | `DEPLOY ZZ` |
| 11 | `TAC ZZ11` | `TAC ZZ11` | `DEPLOY ZZ` |
| 12 | `TAC ZZ12` | `TAC ZZ12` | `DEPLOY ZZ` |
| 13 | `TAC ZZ13` | `TAC ZZ13` | `DEPLOY ZZ` |
| 14 | `TAC ZZ14` | `TAC ZZ14` | `DEPLOY ZZ` |
| 15 | `TAC ZZ15` | `TAC ZZ15` | `DEPLOY ZZ` |
| 16 | `EMER ZZ` | `EMER ZZ` | `DEPLOY ZZ` |

### Zone `3-DEPLOY YY*` (personality references as exported)

| Position | Display channel | Trunking talkgroup reference | Personality reference |
| ---: | --- | --- | --- |
| 1 | `CALL YY*` | `CALL YY` | `DEPLOY YY` |
| 2 | `CMD YY*` | `CMD YY` | `DEPLOY YY` |
| 3 | `TAC YY3*` | `TAC YY3` | `DEPLOY YY` |
| 4 | `TAC YY4*` | `TAC YY4` | `DEPLOY YY` |
| 5 | `TAC YY5*` | `TAC YY5` | `DEPLOY YY` |
| 6 | `TAC YY6*` | `TAC YY6` | `DEPLOY YY` |
| 7 | `TAC YY7*` | `TAC YY7` | `DEPLOY YY` |
| 8 | `TAC YY8*` | `TAC YY8` | `DEPLOY YY` |
| 9 | `TAC YY9*` | `TAC YY9` | `DEPLOY YY` |
| 10 | `TAC YY10*` | `TAC YY10` | `DEPLOY YY` |
| 11 | `TAC YY11*` | `TAC YY11` | `DEPLOY YY` |
| 12 | `TAC YY12*` | `TAC YY12` | `DEPLOY YY` |
| 13 | `TAC YY13*` | `TAC YY13` | `DEPLOY YY` |
| 14 | `TAC YY14*` | `TAC YY14` | `DEPLOY YY` |
| 15 | `TAC YY15*` | `TAC YY15` | `DEPLOY YY` |
| 16 | `EMER YY*` | `EMER YY` | `DEPLOY YY` |

### Zone `4-DEPLOY ZZ*` (personality references as exported)

| Position | Display channel | Trunking talkgroup reference | Personality reference |
| ---: | --- | --- | --- |
| 1 | `CALL ZZ*` | `CALL ZZ` | `DEPLOY ZZ` |
| 2 | `CMD ZZ*` | `CMD ZZ` | `DEPLOY ZZ` |
| 3 | `TAC ZZ3*` | `TAC ZZ3` | `DEPLOY ZZ` |
| 4 | `TAC ZZ4*` | `TAC ZZ4` | `DEPLOY ZZ` |
| 5 | `TAC ZZ5*` | `TAC ZZ5` | `DEPLOY ZZ` |
| 6 | `TAC ZZ6*` | `TAC ZZ6` | `DEPLOY ZZ` |
| 7 | `TAC ZZ7*` | `TAC ZZ7` | `DEPLOY ZZ` |
| 8 | `TAC ZZ8*` | `TAC ZZ8` | `DEPLOY ZZ` |
| 9 | `TAC ZZ9*` | `TAC ZZ9` | `DEPLOY ZZ` |
| 10 | `TAC ZZ10*` | `TAC ZZ10` | `DEPLOY ZZ` |
| 11 | `TAC ZZ11*` | `TAC ZZ11` | `DEPLOY ZZ` |
| 12 | `TAC ZZ12*` | `TAC ZZ12` | `DEPLOY ZZ` |
| 13 | `TAC ZZ13*` | `TAC ZZ13` | `DEPLOY ZZ` |
| 14 | `TAC ZZ14*` | `TAC ZZ14` | `DEPLOY ZZ` |
| 15 | `TAC ZZ15*` | `TAC ZZ15` | `DEPLOY ZZ` |
| 16 | `EMER ZZ*` | `EMER ZZ` | `DEPLOY ZZ` |

## Conventional zone: `5-800 I/O`

All entries reference conventional personality `800 INTEROP`; the listed frequency-option names and frequencies are identical in both exports. Frequencies in MHz. TX squelch = PL at 156.7 Hz; RX squelch = CSQ for all 13 rows.

| Position | Channel / frequency option | RX MHz | TX MHz | TX tone | RX squelch |
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

The `D` entries above are simply the names used in the source exports; they have equal TX/RX frequencies. Their use, authorization and actual coverage must not be inferred from the labels.

## Important source differences — DO NOT silently merge

Although the frequency values and basic zone assignments match, the 13 conventional `Frequency Options` embedded records contain these differences:

| XML field | APX8500 export | APX NEXT export | Impact |
| --- | --- | --- | --- |
| `ASTRO Talkgroup ID` | `Talkgroup 1` | `DECATUR PD` | Different symbolic reference in **each of 13** frequency options; do not silently translate or replace |
| `Mixed Vote Scan Persistent Member` | Field absent | `False` | Model/export schema difference; preserve the APX NEXT field and do not treat absence as explicit `False` |

Those names are **references exactly as exported**, not verified numeric talkgroup IDs or proof that an analog channel uses the setting. More work is needed to establish what each referenced setting means in each CPS context.

APX8500 zone assignments include `Channel Color Backlight Selection ` (with a trailing space in the XML field name), while APX NEXT zone assignments include `Voice Control Name / TTS Announcement`. These manufacturer-specific field names, presence/absence and original text values must be preserved separately.

## Acceptance checks for a future Motorola adapter

1. Import both exports without normalizing away XML field-name whitespace, nested record order or references.
2. Build the shared ordered 77-channel view while preserving each model's complete source record.
3. Resolve conventional frequency options and trunking personality + talkgroup references; detect missing/ambiguous references.
4. Produce a change preview that highlights `ASTRO Talkgroup ID` divergence and model-specific fields instead of assuming full equivalence.
5. Verify no-op export and controlled alias edits inside authorized CPS 39; current report **does not** establish CPS re-import success or native `.mc` editing.
6. Do not use these published values as authorization to transmit on any frequency or talkgroup.

### Provenance and limits

The APX8500 source was `GitHubTemplateMoto.xml`; the APX NEXT source was `MotoAPXNEXTXML(1).xml`. This analysis compares the uploaded XML files only; the original XML, spreadsheet and `.mc` codeplug files are **not** committed to this public repository. See [research findings](motorola-cps39-findings.md).
