# Goal Description

The project aims to build a mobile application ("Taj Alwaqar") providing Quran memorization aid via step-wise audio playback with daily goals, and a supporting C# Audio Analyzer desktop console application to generate pause pointers for long verses. The goal is to set up a solid foundation for both tracking memorization progress (App 1) and providing the necessary segmented audio data (App 2).

## Technical Decisions

- **Mobile App (`src-app`)**: React Native with Expo, TypeScript.
  - State Management: **Zustand** (lightweight, modern, easy to integrate).
  - Local Storage: **react-native-mmkv** (fast, synchronous key-value storage) for settings and plans. (Alternatively, `AsyncStorage` if MMKV presents native build issues with Expo Go).
  - Audio Playback: **expo-av**.
  - UI Library: React Native standard components, ensuring styling remains simple and focused on UX.

- **Audio Analyzer (`src-audio-analyzer`)**: C# .NET 8.0 Console Application.
  - Audio Library: **NAudio** for analyzing volumes and silence gaps to generate pause pointers.

## Proposed Changes

### Data Models and Shared Structures
We will define the core data structures as TypeScript interfaces that represent the JSON data files. This ensures type safety when the Mobile App consumes the Audio Analyzer output.
- `QuranMetadata`: Suras, Verses, Juz, Pages, Editions/Readers.
- `MemorizationPlan`: Configuration, Steps, Daily Goals.
- `AudioPausePointers`: Structure holding the generated pause markers from the C# app.

### Component: Audio Analyzer (C#)
1. **Downloader**: Implement `DownloaderService` with HTTP range requests to support resume capability on interruption.
2. **Analyzer**: Implement `AnalyzerService` leveraging NAudio to detect silence in `.mp3` files, creating a mapping of `verse_id` -> `[pause_start, pause_duration]`.
3. **Data Export**: Output `pause_pointers.json` to be bundled or downloaded by the mobile app.

### Component: Mobile App (React Native/Expo)
1. **Audio Player Manager**: A Zustand slice wrapping `expo-av` handling loading URIs, tracking playback status, seeking, and playing cues (quick review/long verse entry).
2. **Plan Generator Engine**: A pure function utility that takes a `Juz` and `PlanSettings` (Repetition, Reverse, Pauses, Daily Goal configuration) and generates a flat list of `Step` objects and `DailyGoal` markers.
3. **Screens**:
  - `Home/Dashboard`: View current active plan, daily progress, and resume playback.
  - `Plan Configuration`: Select Juz, customize step generation (adult/child presets vs custom).
  - `Plan Preview`: List view of the generated steps showing where the daily wird stops.
  - `Player View`: Active step display, reader selection, quick backward/forward navigation.
  - `Settings`: Volume, queues, language selection.
  - `Daily Goal Completion`: Share screen to generate an image (using `react-native-view-shot` or similar).

## Verification Plan

### Automated Tests
- Write unit tests for the Plan Generator Engine to ensure Minimum/Maximum bounds for Suras/Pages are respected correctly during daily goal calculation.
- Write unit tests for the C# Audio Analyzer's pause detection logic on sample `.wav`/`.mp3` files.

### Manual Verification
- Generate plans with different configurations and verify the step list reflects the chosen repitition/pauses.
- Play audio steps and ensure background playback, cues, and pause injection work according to plan settings.
- Interrupt the C# download process and resume it to ensure no data loss/corruption.
