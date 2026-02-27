# Taj Alwaqar

This is a mobile app built on Expo React Native.
The purpose of this app is to provide Quran memorization assistance by allowing users to create step-wise plans for audio playback.

## What is a step?

A step is a segment of the Quran that is played back to the user. It is used to divide the Quran into manageable chunks for memorization. Things that are considered steps:

1. Aya
1. Each repetition of the aya

## Features

### App 1: Mobile App "Taj Alwaqar"

#### Audio playback

1. Selection of sheikh recitation audio recordings
1. Support resuming from step that you stopped last time
1. Navigation between steps
1. Go back or forward in steps: 1x step, 5x steps, 10x steps.

#### Memorization plans generation 

1. Pre-configured memorization plan settings (quick setup)
1. Step-wise plan generation
1. Interface to preview the step-wise plan.

1. Selection of the Juz to generate the plan on.
1. Memorization plan settings:
    1. Repitition of ayat: None, 1x, 2x, 3x, and so on
    1. Enable extra pauses in long verses / ayat
    1. Enable pause after each aya
    1. Pause duration multiplier (1x, 1.5x, 2x) based on the duration of the aya being played
    1. Setting of daily goal (Daily Wird ورد):
        1. After finishing number of suras (Applicable for short suras)
        1. After finishing number of pages (Applicable for long suras)
        1. Option to select either "Minimum" or "Maximum" version of the daily goal by comparing the total pages of both options above. Examples:
            * Suras = 3, Pages = 5, but the 3 suras are very short (they fit in 1 page), so the minimum option will be 1 page and the maximum option will be 5 pages.
            * Suras = 3, Pages = 5, but the 3 suras are very long (they fit in 40 pages), so the minimum option will be 5 pages and the maximum option will be 40 pages.
    1. Enable quick review: just before reaching goal, it will play back the steps you have reached but without repitition of ayat.




#### Resume support for memorization plans

### App 2: Audio Analyzer

#### Analyze long verses / ayat and generate pause pointers



# Development toolkit notes

## Dev Tools on a Windows machine

### Mobile App

1. Git
1. Node JS
    1. Configure powershell execution policy: `Set-ExecutionPolicy RemoteSigned`
    1. Expo: npm i -g expo-cli
    1. Install dependencies: npm i
1. Visual Studio Code
1. Java JDK
1. Android Studio
1. (Optional) AI tool (Antigravity, etc.)


### Audio Analyzer

1. Git
1. Visual Studio
1. .NET 8.0
1. Nuget:
    1. NAudio
