# JVCKENWOOD Viking Armada Fixture — 800IO

This file is provided for URPM interoperability research and is **courtesy of Colin Zapalac**.

## File

- `800IO.aep` — Viking Armada template/project artifact.

## Integrity

- SHA-256: `aa484bea8c1fd3dce5561157b1f970cc82580f57984a0d287608541d5f01dc74`

## Template behavior

Armada templates are not treated as being bound to a particular subscriber firmware release or installed feature set.

When a template is applied to a radio:

- a radio with sufficient feature parity may accept the full template;
- a radio that is not optioned for every feature represented by the template may receive only the programming it supports; and
- Armada warns when a target radio cannot accept all features represented by the template.

URPM should therefore distinguish **template provenance** from **target-radio capability**. The absence or presence of a feature in an Armada template must not be interpreted as proof that every radio of the same model or firmware supports that feature.

## Provenance

The current `800IO.aep` was produced in **Armada 1.48.11** from a duplicated master template.

That master template originally came from a **VP8000** running **1.40.x firmware** and was optioned for:

- all-band operation;
- P25 trunking;
- P25 Phase 2;
- OTAR;
- AES multi-key; and
- OTIP.

The duplicated working copy was then reduced to the intended interoperability-template content, retaining only the limited zones/system content needed for this fixture.

The VP8000 firmware and feature-option information above describes the **origin of the master template**. It is not a firmware requirement encoded by the resulting AEP template.

## Research use

Use this file for read-only format analysis, import testing, comparison, capability-warning design, and controlled fixture development unless and until a manufacturer-supported programming path is established.

Do not infer authorization to transmit from any channel or system information represented in the sample.
