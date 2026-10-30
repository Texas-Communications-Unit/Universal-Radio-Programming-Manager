# Contributing to TX-COMU Universal Radio Programming Manager

Thank you for helping improve the Universal Radio Programming Manager (URPM).

## Project principles

URPM is intended for authorized public-safety communications work. Contributions must preserve these principles:

- Offline-first field operation.
- Manufacturer-neutral core data structures.
- Explicit validation before programming radios.
- Backup and recovery before destructive changes where supported.
- No bypass of manufacturer licensing, authentication, access controls, or security protections.
- No unauthorized reverse engineering of proprietary programming protocols.
- No real encryption keys, credentials, subscriber secrets, or protected system information in the repository.
- No proprietary manufacturer software, SDKs, documentation, or file formats unless redistribution is explicitly authorized.

## Before opening an issue

Search existing issues first. When reporting a bug, include only sanitized data.

Never attach real agency codeplugs, key material, passwords, certificates, system keys, authentication data, or sensitive incident information to a public issue.

## Development workflow

1. Create or select an issue describing the work.
2. Create a focused branch from `main`.
3. Keep changes small enough to review.
4. Add or update tests for behavior changes.
5. Update documentation when interfaces, schemas, or workflows change.
6. Open a pull request and reference the related issue.
7. Do not merge until required review and checks have completed.

## Architecture expectations

Manufacturer support should be implemented through isolated adapters. The universal data model must not silently discard manufacturer-specific information during import/export.

Adapters should clearly declare:

- Supported manufacturers and model families.
- Supported firmware/software versions where known.
- Integration level: file-based, assisted, or direct programming.
- Required manufacturer software, drivers, SDKs, or licenses.
- Read/write capabilities.
- Known unsupported features.
- Validation and recovery behavior.

## Test data

Use fictional or fully sanitized fixtures. Sample frequencies, talkgroups, radio IDs, serial numbers, agency names, and incident names must not represent operational systems unless the information is already public and appropriate for inclusion.

## Security issues

Do not report exploitable security issues in a public GitHub issue. Follow [SECURITY.md](SECURITY.md).

## Coding style

The initial implementation target is C#/.NET on Windows. Use clear naming, nullable reference types where practical, dependency injection at integration boundaries, and testable interfaces around manufacturer adapters and device I/O.

## Pull requests

Pull requests should explain:

- What problem is being solved.
- What changed.
- How the change was tested.
- Any manufacturer/model limitations.
- Any migration, compatibility, or safety impact.
- Whether the change touches sensitive radio programming behavior.

By contributing, you agree that your contribution may be distributed under the license ultimately adopted by the project. Do not submit code or documentation you do not have the right to contribute.
