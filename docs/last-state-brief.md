# Last State Brief â€” WBS Tool

Generated: 2026-07-01 18:09:31

## Repository
C:\Projekte\wbs-tool

## Current Git State
Branch: feature/import-validation
Last commit: 1aee52c docs: add Copilot context package for WBS MVP
Working tree: clean

## Product Goal
We are developing a WBS / project control / resource management system.
Excel will be replaced step by step as the leading working basis.

The system combines:
- WBS / project structure
- process phases / Leistungsphasen (LPH)
- resources and role assignments
- competencies
- cross-project capacity
- resource demand workflow
- import/data-quality issues

## Target Architecture
- .NET 9 Web API = fachlicher Kern / business core
- EF Core = data access
- SQLite local now
- Azure SQL later
- React + Vite frontend currently
- SharePoint/SPFx later as UI / entry point only
- SharePoint is NOT the core database
- API is the single source for business logic

## Non-Negotiable Rule
Dashboard and WBS tree totals use only consolidated WbsNode values:
- PlannedHours
- ActualHours

ResourceAssignments are detail data and must never be used for dashboard/tree totals.

Reason:
The original Excel separates:
1. WBS_Knoten = consolidated WBS values per WBS ID
2. Ressourcen_Zuordnung = multiple person/role rows per WBS ID

Summing ResourceAssignments for dashboard/tree causes double counting.

## MVP v1.0
MVP includes:
- Project
- WbsNode
- ResourceAssignment
- ImportIssue
- ProcessPhase
- WbsPhaseMapping
- Person
- Competency
- PersonCompetency
- WbsRequiredCompetency
- CapacityAllocation
- ResourceDemand
- RoleAssignment

MVP functions:
- WBS tree
- WBS detail panel
- dashboard from WbsNodes only
- resource panel per WBS node
- ImportIssues / data quality
- simple LPH assignment
- simple competency assignment
- simple capacity display
- manual ResourceDemand creation
- governance foundation

## Governance MVP
Roles:
- Admin
- Owner
- ProjectManager
- ResourceManager
- Contributor
- Reviewer
- Reader

Scopes:
- Global
- Project

Rules:
- role-based access only
- no direct individual permissions
- no object-level WBS node permissions in MVP
- no complex delegation engine in MVP
- roles assigned only by Admin/Owner
- ProjectManager cannot assign roles
- Admin = technical administration, not automatic fachliche Freigabe
- Owner = global fachliche Governance
- ResourceManager reviews/approves/rejects/covers/closes ResourceDemand

## Regression Values
Project: Amprion PQ Freileitung
ProjectId: 7f3faaa5-1245-4d43-978b-88b5bab3a23b

Expected dashboard:
- totalPlannedHours = 681
- totalActualHours = 674
- progressPercent approx. 98.97
- blockedNodes = 0

Expected counts:
- WBS nodes = 49
- ResourceAssignments = 81
- Persons = 16
- RateCategories = 5
- Status values = 6

Control WBS node:
- WBS-ID: 2.1.2
- Title: Identifikation Fremdleitungen / Schutzgebiete
- plannedHoursTotal = 16
- actualHoursTotal = 24
- visible resources: Ahmad, Ibrahim, Phine, Victor

## Workflow Split
ChatGPT / Arcadis GPT / Chat Copilot:
- business logic
- architecture
- governance
- MVP decisions
- risks and alternatives
- GitHub Copilot prompts

GitHub Copilot in VS Code:
- implementation slices only
- no architecture decisions
- no implicit data model assumptions
- no broad agent runs over the whole repo

## Repository Context Files
Existing context files should be in the repo:
- docs/copilot-project-context.md
- docs/data-source-mapping.md
- docs/mvp-scope-v1.md
- docs/governance-mvp-v1.md
- docs/implementation-rules.md
- docs/regression-checks.md
- repros/repro-workflow.md
- prompts/*.md

## Default Working Rule
Before implementation:
1. business analysis
2. risks
3. alternatives
4. data model impact
5. UX impact
6. governance impact
7. Azure SQL / SharePoint-SPFx impact
8. handover impact for Arcadis Digital Engineering
9. recommendation
10. only then implementation
