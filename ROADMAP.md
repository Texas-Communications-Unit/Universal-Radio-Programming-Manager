# Project Roadmap

This roadmap is directional and will evolve as manufacturer partnerships, technical constraints, and field requirements are validated.

## Phase 1 — Requirements and foundation

- Define the manufacturer-neutral programming data model.
- Establish repository governance, contribution, security, and testing practices.
- Define capability metadata by manufacturer, product family, exact model, hardware revision, firmware, programming-software version, installed/licensed feature set, and integration level.
- Define incident template and radio inventory models.
- Establish backup, restore, audit, and validation requirements.
- Document authorization boundaries for manufacturer integrations.

## Phase 2 — Offline core application

- Create the C#/.NET Windows application.
- Implement SQLite-backed local storage.
- Build incident/template management.
- Build radio inventory and programming-history workflows.
- Implement schema versioning and migration.
- Implement backup metadata and restore workflows.
- Add configuration validation and change previews.

## Phase 3 — Motorola APX pilot

- Define the APX adapter contract.
- Implement authorized import/export workflows first.
- Validate preservation of unsupported/manufacturer-specific fields.
- Add model/firmware compatibility reporting.
- Expand to assisted or direct programming only through manufacturer-approved interfaces.

## Phase 4 — Multi-manufacturer expansion

Priority order:

1. Motorola APX
2. L3Harris public-safety P25 families
3. JVCKENWOOD Viking VP families
4. BK Technologies BKR and supported legacy families
5. Tait Communications public-safety radio families

For each adapter, document support at the exact-model, firmware/software-version, and feature-option level along with the supported integration level and limitations.

## Phase 5 — Authorized programming and field validation

- Implement approved read/write interfaces.
- Add pre-program backup and post-program verification.
- Add failure recovery and rollback behavior.
- Conduct controlled test-radio validation.
- Conduct COML/COMT workflow evaluation.

## Phase 6 — Optional nationwide template services

- Build an optional template repository and synchronization service.
- Preserve full offline operation.
- Add provenance, review, approval, and access-control mechanisms.
- Prevent sensitive system data from being distributed through general-purpose templates.

## Release gates

A feature should not be considered production-ready merely because it functions in a lab. Release gates should include compatibility documentation, validation behavior, recovery procedures, sanitized automated tests, security review, and field acceptance where applicable.
