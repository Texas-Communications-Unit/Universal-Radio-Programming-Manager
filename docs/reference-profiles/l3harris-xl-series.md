# L3Harris XL Series Canonical Reference Profile

This document implements the repository-facing portion of GitHub issue #20 and is subordinate to the [Reference Codeplug Research Standard](../reference-codeplug-standard.md).

## Purpose

This profile defines the canonical, reproducible reference configuration for L3Harris public-safety P25 radios used by the TX-COMU Universal Radio Programming Manager (URPM) project.

Initial focus is placed on the converged multi-band **XL Series** (XL-200P, XL-185P, XL-400P, XL-200M, XL-185M) and legacy P25/EDACS platforms (XG-100M, XG-75P, XG-25P) programmed via **Radio Personality Manager 2 (RPM2)** and legacy **RPM**.

The values in this document must be synthetic, non-operational, and suitable for public reproduction by contributors.

Until values are approved, fields remain marked **TBD**. Do not substitute real agency, incident, subscriber, system, or cryptographic data.

## Profile status

- Profile version: `0.1-draft`
- Status: **Awaiting controlled values**
- Target: L3Harris XL Series (XL-200P, XL-185P, XL-200M)
- Related issue: #20
- Capability model: #26
- Research standard: #27
- Architecture: #13

## Radio / programming environment

| Item | Controlled value |
| --- | --- |
| Manufacturer | L3Harris Technologies |
| Product family | XL Series (Portable & Mobile) |
| Exact model | XL-200P (Converged Multi-Band P25 Portable) |
| Hardware revision | TBD |
| Firmware version | TBD |
| Programming software | Radio Personality Manager 2 (RPM2) |
| Programming software version | TBD |
| Programming interface / cable | USB Side Connector (CA-011854-001) / Over-The-Air (OTAP) |
| Band / range variant | Multi-Band: VHF (136-174 MHz), UHF (378-522 MHz), 700/800 MHz (768-861 MHz) |
| Installed / licensed options relevant to sample | TBD (e.g., P25 Trunking, P25 Phase 2, LTE, OTAR, Single-Key/Multi-Key AES) |
| Native file / export format | RPM2 Personality (`.rpm2`), RPM2 XML export format |

## Reference Profile A — Conventional

| Field | Controlled value |
| --- | --- |
| Zone name | TBD |
| Channel name | TBD |
| Channel type | TBD (Analog FM / P25 Conventional) |
| RX frequency | TBD |
| TX frequency | TBD |
| RX squelch type | TBD (CSQ / CTCSS / CDCSS / NAC) |
| RX squelch value / NAC | TBD |
| TX squelch type | TBD (None / CTCSS / CDCSS / NAC) |
| TX squelch value / NAC | TBD |
| Channel spacing / bandwidth | TBD (12.5 kHz / 20 kHz / 25 kHz) |
| Transmit power | TBD (Low / Med / High) |
| Direct / talkaround state | TBD |
| Scan state / list | TBD |
| Secure / clear state | TBD |
| Emergency behavior | TBD |
| Required automatically-created L3Harris objects/defaults | TBD |

## Reference Profile B — P25 Trunked

| Field | Controlled value |
| --- | --- |
| System alias | TBD |
| WACN | TBD (e.g., 0xA4xxx / synthetic) |
| System ID | TBD |
| RFSS ID, if required | TBD |
| Site ID, if required | TBD |
| Site alias | TBD |
| Frequency list / Control channels | TBD |
| Talkgroup alias | TBD |
| Talkgroup ID | TBD |
| Zone name | TBD |
| Channel position / name | TBD |
| Individual / Radio Unit ID (LID) | TBD (Synthetic) |
| Secure / clear state | TBD |
| Scan state | TBD |
| Emergency behavior | TBD |
| Failsoft behavior | TBD |
| Roaming / ProScan criteria | TBD |
| Required automatically-created L3Harris objects/defaults | TBD |

## Capability matrix & feature support states

Following issue #26, capabilities are explicitly modeled per device without assuming brand-wide uniformity:

| Capability key | Supported models / options | Description |
| --- | --- | --- |
| `band-multiband` | XL-200P, XL-200M, XL-400P | Simultaneous multi-band operation (VHF, UHF, 700/800 MHz) |
| `p25-phase1` | XL Series, XG-75, XG-100M | P25 Phase 1 FDMA Common Air Interface |
| `p25-phase2` | XL Series, XG-75 (licensed) | P25 Phase 2 TDMA 2-slot trunking |
| `edacs-provoice` | Legacy option on XL / XG | Harris EDACS / ProVoice trunked voice |
| `broadband-lte` | XL-200P, XL-185P (optional cell modem) | LTE data and BeOn mission-critical voice over cellular |
| `positioning-gps` | XL Series standard | Integrated GNSS / GPS location reporting |
| `bluetooth-audio-data` | XL Series standard | Bluetooth 4.0 / BLE audio and peripheral connectivity |
| `crypto-aes256` | Optioned models | FIPS 140-2 validated 256-bit AES encryption |

## Implementation levels

1. **Level 1 — File-Based Integration:**
   - Parsing and export of sanitized RPM2 XML personality structures.
   - Validation of frequency boundaries, band limits, channel names, and trunking IDs.
2. **Level 2 — Assisted Configuration:**
   - Generating vendor-neutral interoperability templates mapped into native RPM2 import templates.
3. **Level 3 — Direct Device Interfacing:**
   - Requires authorized manufacturer development agreements. Standard field operations focus on Level 1 and Level 2 workflows.

## Prohibited content

Do not commit or submit:

- operational incident codeplugs;
- real public-safety system identifiers (WACN/SysID);
- real subscriber/radio identifiers (LIDs);
- encryption keys or key-management material;
- credentials or certificates;
- proprietary manufacturer software (RPM/RPM2 executables) or restricted documentation.
