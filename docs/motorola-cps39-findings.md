# Motorola CPS 39 XML and native-codeplug findings

Status: preliminary investigation, not proof of CPS import acceptance or native-codeplug edit support. Updated 2026-11-01.

## Confirmed source context
- Fixture `MOTO-APX8500-CPS39-001`: Motorola APX8500 mobile radio; user-confirmed export from APX CPS version 39; original file name `GitHubTemplateMoto.xml`.
- Fixture `MOTO-APXNEXT-CPS39-002`: Motorola APX NEXT portable; user-confirmed export using APX CPS version 39; original file name `MotoAPXNEXTXML(1).xml`, with a corresponding Excel flattening `MotoAPXNEXTExcel.xlsx`.
- Both XML samples declare `<import_export_doc><Version>2</Version>`; XML document version 2 is not the same as CPS application version 39.
- Associated native codeplug files were supplied as `.mc` for both models. These are research artifacts **not included** in this public repository.

## XML structural model
Both samples use:
```text
import_export_doc
  Version / Language
  Root (export attributes)
    Recset (Name, Id)
      Node (Name, ReferenceKey)
        Section (Name, id)
          Field (Name, text)
          EmbeddedRecset (Name, Id)
            EmbeddedNode (Name, ReferenceKey)
              EmbeddedSection (Name, id)
                Field (Name, text)
```
`ReferenceKey` and the order of repeated embedded items are significant to the dependency graph. Examples include conventional personalities with nested frequency options, ASTRO talkgroup lists, trunking personalities and system references, and zone channel assignments.

## Cross-model findings
Observed in preliminary comparisons of these two *particular* files:
- APX8500 XML: 52 top-level record sets, 114 top-level nodes, 5,605 Field elements.
- APX NEXT XML: 46 top-level record sets, 115 top-level nodes, 5,520 Field elements.
- Both have five zone names: `DEPLOY YY`, `DEPLOY ZZ`, `DEPLOY YY*`, `DEPLOY ZZ*`, `800 I/O`.
- Both have 77 zone channel assignments: 64 trunking and 13 conventional.
- Both have four trunking personalities, one conventional personality and one trunking system in the studied comparison.
- The shared assigned channel layout and principal channel references appeared to match; these findings do **not** establish identical complete configuration or validated cross-model import.
- Model-specific fields differ. APX NEXT includes portable buttons, voice-control/TTS, additional OTAR, LTE and broadband-related properties. APX8500 includes mobile control-head and other hardware-dependent properties. Subscriber IDs differ and must never be copied as part of common templates.

## Example Motorola references
An assigned channel is not just a frequency or talkgroup number: zone assignment -> personality -> frequency option (conventional) OR zone assignment -> trunking personality -> trunking system + talkgroup (trunking). Scan lists can reference specific zones and channel assignments. An importer must resolve these references and report missing or ambiguous targets.

## Spreadsheet handling
The APX NEXT workbook had 5,575 populated data rows, versus 5,520 XML Field elements; the workbook is a *flattened inspection aid*, not a lossless canonical source. XML is the source-of-truth fixture for parsing and round-trip tests.

## Native .mc files: current limits
Preliminary binary examination found readable metadata including model and software release (`R39.00.00`) and opaque binary payloads. File sizes reported: APX NEXT 161,794 bytes; APX8500 163,534 bytes. A 186-byte metadata area and apparent payload offset 254 were identified in this specific pair, but these offsets are observations, NOT a guaranteed published format. The opaque payloads did not yield confirmed native channel/personality decoding or validated edit/rebuild support. High entropy alone does not establish encryption.

Thus native `.mc` support is **metadata inspection + unmodified, protected backup only** until a supported vendor path is established. No proprietary protection bypass or speculative native codeplug writer is planned.

## Test plan
1. Securely retain authorized originals off-repository; record SHA-256 hashes in an internal fixture registry.
2. Parse both XML documents; construct object/ref graph and report missing references.
3. Compare canonical channel layouts and conventional frequency/squelch parameters, trunked system/talkgroup/selection metadata, and scan list references.
4. Execute no-edit parse/export, comparing semantic equivalence and unexpectedly changed XML paths.
5. Change one alias in an isolated test copy; require diff to contain only expected fields and dependent reference updates.
6. Verify exports by importing into authorized Motorola CPS 39; do not test on in-service radios.
7. Document supported/unsupported CPS versions and radio model features before making compatibility claims.

## Redaction
Original exports and codeplugs are **not public test fixtures**. They may contain radio IDs, network parameters, key-selection references, security configuration, certificate material and other sensitive operational data. Build synthetic minimal fixtures with explicit release approval. See [radio configuration data handling](radio-configuration-data-handling.md).
