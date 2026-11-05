# BK Technologies RES Fixture — 800IO

These files are provided for URPM interoperability research and are **courtesy of Colin Zapalac**.

## Files

- `800IO.neo` — native BK Technologies RES configuration artifact.
- `800IO_export.xls` — human-readable spreadsheet export derived from the RES template.

The `.neo` file is the canonical native RES artifact. The spreadsheet is a derived inspection aid and should not be treated as a lossless replacement for the native file.

## Integrity

- `800IO.neo`
  - SHA-256: `807425c89a6831b0492e6eb410a06a457b32ea5f361e238ffa6d71893822b8d5`
- `800IO_export.xls`
  - SHA-256: `b6a633536722d56fcc074300aa1f8971f897d1c2ac6d72048377ca30318ed8b1`

## Template behavior

RES spreadsheet/template artifacts should not be treated as being bound to a particular radio firmware release or as a declaration that every target radio has the same feature set.

A target radio may accept the programming applicable to the features/options it supports. URPM should therefore keep template content separate from the capability profile of the specific target radio.

## Provenance

The `800IO_export.xls` fixture was generated with **RES 5.15.0** from a **clean template sheet for an all-band BKR9000**.

This is template provenance, not a firmware compatibility requirement. No specific BKR9000 firmware revision is implied by the XLS fixture.

Likewise, the fixture should not be interpreted as asserting that every BKR9000 has identical installed or licensed features.

## Research use

Use these files for read-only format analysis, import testing, comparison, field mapping, and controlled fixture development unless and until a manufacturer-supported programming path is established.

Do not infer authorization to transmit from any channel or system information represented in the sample.
