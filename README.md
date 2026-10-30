# TX-COMU Universal Radio Programming Manager

The **TX-COMU Universal Radio Programming Manager (URPM)** is a nationwide, offline-first, multi-manufacturer radio programming and configuration management application designed for Communications Unit Leaders (COMLs), Communications Technicians (COMTs), public safety radio technicians, and authorized emergency communications personnel.

The goal of URPM is to provide a common operational platform for managing and preparing radio configurations across multiple manufacturers without forcing incident communications personnel to rebuild the same programming information in separate vendor applications.

Initial manufacturer priorities include:

- Motorola APX
- L3Harris public safety P25 radios
- JVCKENWOOD Viking VP series
- BK Technologies BKR and supported legacy platforms

URPM is intended to support complete programming workflows where manufacturer authorization, licensing, technical documentation, and supported interfaces make that possible. The project will not rely on bypassing manufacturer security controls, licensing systems, proprietary protections, or unsupported reverse engineering.

## Core Objectives

URPM will provide a manufacturer-neutral programming database that can be translated into supported manufacturer-specific configurations.

Planned capabilities include:

- Offline-first Windows desktop operation
- Common radio programming database
- Incident-specific programming templates
- Conventional analog and P25 channel management
- Zone, scan list, talkgroup, and system configuration management
- Manufacturer-specific import and export
- Radio inventory and asset tracking
- Original configuration backup before programming
- Configuration restoration and recovery workflows
- Programming history and audit logging
- Model and firmware compatibility validation
- Configuration change previews before radio writes
- Manufacturer adapter architecture
- Optional future online template sharing and synchronization

## Architecture

URPM is being designed around a modular architecture consisting of:

1. **Desktop Application**
   - Incident management
   - Radio inventory
   - Template management
   - Programming workspace
   - Backup and restoration
   - Reports and audit history

2. **Universal Programming Engine**
   - Manufacturer-neutral configuration model
   - Validation and compatibility rules
   - Translation between common and vendor-specific settings

3. **Manufacturer Adapter Layer**
   - Separate adapters for Motorola, L3Harris, JVCKENWOOD, BK Technologies, and future manufacturers
   - Support for file-based integration, assisted programming, and direct programming where authorized

4. **Local Data Layer**
   - Offline incident databases
   - Radio inventory
   - Configuration versions
   - Backups
   - Programming records
   - Template libraries

The initial technical direction is a **C#/.NET Windows desktop application with SQLite-based local storage and a versioned manufacturer-neutral data schema**.

## Manufacturer Integration Levels

URPM is intended to support multiple levels of manufacturer integration depending on available documentation, licensing, and technical support.

### Level 1 — File-Based Integration

Import and export supported manufacturer configuration formats while using the manufacturer's programming software for the final radio write.

### Level 2 — Assisted Programming

Use manufacturer-approved software interfaces, automation methods, SDKs, or APIs to prepare and execute supported programming workflows.

### Level 3 — Direct Programming

Read, modify, write, verify, and restore supported radios through manufacturer-approved programming interfaces.

Not every radio family is expected to support the same integration level.

## Incident Template Model

A major goal of URPM is to allow a COML or COMT to create an incident communications template once and apply the appropriate configuration to multiple supported radio families.

Templates may contain:

- Command channels
- Tactical channels
- Logistics channels
- Staging channels
- Mutual aid resources
- Interoperability channels
- Zone layouts
- Scan configurations
- Radio assignments
- Incident-specific configuration notes

The system should identify unsupported or incompatible settings instead of silently dropping configuration data.

## Radio Inventory and Recovery

URPM will maintain radio inventory information including:

- Manufacturer
- Model
- Serial number
- Asset identifier
- Firmware version
- Current assignment
- Programming history
- Configuration version
- Backup history

Where supported, the system should capture the original radio configuration before programming and associate that backup with the specific radio and programming session.

## Security and Operational Safety

Because URPM is intended for mission-critical communications environments, configuration integrity and operational safety are core design requirements.

The project will include:

- Explicit confirmation before programming
- Configuration validation before radio writes
- Backup-before-change workflows
- Versioned templates
- Audit logging
- Role-based access controls
- Secure local storage
- Compatibility checks by model, firmware, and programming interface

Encryption keys, protected credentials, and other sensitive key-management material should remain within authorized manufacturer-supported systems and should not be distributed through general-purpose incident templates.

## Offline-First Design

URPM must remain usable during incidents where internet connectivity is unavailable, unreliable, or prohibited.

Core operations will not depend on:

- Cloud authentication
- Remote databases
- Internet connectivity
- Online template repositories

Future online services may provide optional template synchronization and sharing without becoming a dependency for field operations.

## Manufacturer Partnership Program

Texas Communications Unit is a nonprofit organization seeking partnerships with radio manufacturers to support responsible development of URPM.

Partnership requests may include:

- Programming software licenses
- Programming cables and interfaces
- SDKs and APIs
- File format documentation
- Technical manuals
- Compatibility information
- Loaner or evaluation radios
- Engineering and technical assistance
- Development and testing support

The intent is to build authorized integrations that complement manufacturer-supported programming ecosystems while improving interoperability and field efficiency for qualified emergency communications personnel.

## Initial Development Phases

### Phase 1 — Requirements and Data Model
Define the common programming schema, security model, manufacturer compatibility framework, and incident template structure.

### Phase 2 — Offline Core Application
Build the Windows desktop application, SQLite database, radio inventory, template editor, and versioning system.

### Phase 3 — Motorola APX Pilot
Develop the first manufacturer adapter and validate import/export and supported programming workflows.

### Phase 4 — Multi-Manufacturer Expansion
Add L3Harris, JVCKENWOOD Viking, and BK Technologies adapters.

### Phase 5 — Authorized Direct Programming
Implement direct radio programming where manufacturer-approved interfaces are available.

### Phase 6 — Nationwide Template Services
Develop optional online template sharing, synchronization, review, and distribution.

## Initial MVP

The first usable release should include:

- Offline Windows application
- Common programming database
- Incident templates
- Radio inventory
- Configuration validation
- Backup and restoration records
- Manufacturer adapter framework
- Motorola APX integration pilot
- Manufacturer-specific import/export

## Project Mission

The long-term goal of the **TX-COMU Universal Radio Programming Manager** is to give qualified incident communications personnel one consistent, reliable, and manufacturer-neutral workflow for preparing and managing public safety radios during planned events, mutual aid operations, disasters, and large-scale emergency incidents.

The project is being developed by **Texas Communications Unit** in support of public safety interoperability and emergency communications.
