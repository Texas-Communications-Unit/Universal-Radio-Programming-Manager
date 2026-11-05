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

- the native/exported codeplug, template, or configuration file, when redistribution is permitted;
- a `README.md` describing the sample;
- manufacturer;
- product family;
- exact model or source model, when the artifact is model-derived;
- hardware revision, if relevant and known;
- firmware version or firmware lineage **when the artifact actually depends on or records it**;
- programming software and version;
- band/range variant;
- relevant installed/licensed feature options when they describe provenance or compatibility;
- file type/extension;
- whether the file was saved/exported from software, created from a template, or read from a radio;
- which URPM reference profile it implements;
- any fields/settings the platform could not represent;
- any defaults or extra records automatically created by the programming software.

## Template provenance versus target-radio capability

Do not assume every vendor artifact is firmware-bound.

Some programming environments use reusable templates whose contents are applied according to the capabilities and options of the target radio. In those cases:

- record the software/version and the source of the template;
- record source-radio firmware/features only as provenance when known;
- do not represent source firmware as a compatibility requirement unless the vendor format or software actually enforces one;
- validate target-radio capabilities separately; and
- preserve warnings when a target radio cannot accept every feature represented by a template.

Motorola-style firmware/model references, Armada template behavior, RES templates, and other manufacturer workflows may therefore require different metadata semantics.

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
