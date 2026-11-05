# Public Test Fixtures

This directory contains public, reviewed test fixtures used by the TX-COMU Universal Radio Programming Manager (URPM) project.

Only **synthetic or fully sanitized** files may be committed here.

## Directory layout

Use:

```text
fixtures/public/
  motorola/
    apx8500/
    apx-next/
  l3harris/
  jvckenwood/
  bk-technologies/
  tait/
```

Add additional manufacturer and model folders as needed.

## Each sample set should include

- the native/exported codeplug or configuration file, when redistribution is permitted;
- a `README.md` describing the sample;
- manufacturer;
- product family;
- exact model;
- hardware revision, if known;
- firmware version;
- programming software and version;
- band/range variant;
- relevant installed/licensed feature options;
- file type/extension;
- whether the file was saved/exported from software or read from a radio;
- which URPM reference profile it implements;
- any fields/settings the platform could not represent;
- any defaults or extra records automatically created by the programming software.

## Do not commit

- operational agency or incident codeplugs;
- real P25 system identifiers;
- real subscriber/radio IDs;
- operational talkgroup IDs unless explicitly approved as part of a synthetic reference set;
- encryption keys or key-management material;
- credentials, certificates, or sensitive network information;
- proprietary manufacturer software;
- restricted documentation;
- files whose redistribution rights are unclear.

If a file is needed for private research but is not suitable for the public repository, keep it outside GitHub or under a locally ignored path such as `fixtures/private/`.

Before adding a public fixture, review the [Reference Codeplug Research Standard](../../docs/reference-codeplug-standard.md) and the [Codeplug Contribution Request](../../docs/codeplug-contribution-request.md).
