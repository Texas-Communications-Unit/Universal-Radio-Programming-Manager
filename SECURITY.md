# Security Policy

## Scope

The TX-COMU Universal Radio Programming Manager handles configuration information for public-safety communications equipment. Security, data integrity, and operational safety are treated as core requirements.

## Reporting a vulnerability

Please **do not open a public GitHub issue** for a suspected vulnerability that could expose credentials, cryptographic material, radio programming data, protected system information, or a method for bypassing manufacturer security controls.

Use GitHub's private vulnerability reporting feature if it is enabled for this repository. If private reporting is not available, contact Texas Communications Unit through an official private contact channel listed by the organization and reference this repository.

Include enough sanitized information to reproduce the issue without attaching sensitive operational data.

## Sensitive information that must not be committed

Do not commit or upload:

- Encryption keys or key-management exports.
- Passwords, API keys, certificates, or private keys.
- Real subscriber authentication secrets.
- Protected trunked-system credentials or access data.
- Proprietary manufacturer SDKs or licensed programming software.
- Restricted manufacturer documentation.
- Real agency codeplugs unless explicitly authorized for public release.
- Sensitive incident or deployment information.
- Device captures containing protected programming traffic or credentials.

If sensitive information is accidentally committed, treat it as compromised. Remove it from the repository history and rotate or revoke the affected secret where applicable.

## Supported versions

Until the first stable release, security fixes are applied to the active development branch and the latest published prerelease. A formal supported-version matrix will be published when versioned releases begin.

## Safety-related defects

A defect that could cause a radio to be programmed incorrectly, lose a recoverable configuration, transmit on an unintended resource, or silently omit critical settings should be treated as a high-priority safety issue even when it is not a traditional cybersecurity vulnerability.
