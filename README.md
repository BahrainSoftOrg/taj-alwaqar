# Taj Alwaqar

This is an islamic mobile app. The purpose of this app is to provide Quran memorization assistance by allowing users to create "steps" in a step-wise plan for audio playback.

In a busy life where its sometimes difficult to find time to memorize the holy Quran, the app provides a way to aid the memorizers by being able to listen to Quran but with memorization as a key goal.

There are many Quran recitation applications, but none of them are centered around the goal of memorization aid.

This is not a replacement of traditional Quran memorization, but rather an aid to make memorization easier.

# What is a step?

A step is a segment of the Quran that is played back to the user. It is used to divide the Quran into manageable chunks for memorization. Things that are considered steps:

1. Verse / aya
1. Each repetition of the verse / aya
1. Each segment of a broken down long verse / aya

# Functional Features

## App 1: Mobile App "Taj Alwaqar" [Folder: src-app]

### Audio playback

1. Selection of reader (sheikh) recitation audio recordings
1. Support resuming from step that you stopped last time
1. Navigation between steps
1. Go back or forward in steps: 1x step, 5x steps, 10x steps.
1. Audio cue when entering quick review mode (If enabled in plan settings).
1. Audio cue when entering long verse / aya.
1. Settings:
    1. Enable/Disable any of the above audio cues.
    1. Playback volume.
    1. Audio cues volume.

### Memorization plans generation

1. Pre-configured memorization plan settings (quick setup)
1. Step-wise plan generation
1. Interface to preview the step-wise plan: List of steps, and list of daily goals (aka Daily Wird ورد).
1. Selection of the Juz to generate the plan on.
1. Allow generation of multiple plans, each with its own progress and settings.
1. User can select the plan to use.
1. Memorization plan settings:
    1. Repetition of verses / ayat: None, 1x, 2x, 3x, and so on
    1. Reverse order of suras: Start from the last sura in the Juz instead of first sura
    1. Enable extra pauses in long verses / ayat
    1. Enable pause after each verse / aya
    1. Pause duration multiplier (1x, 1.5x, 2x) based on the duration of the verse / aya being played
    1. Enable quick review: just before reaching the daily goal, it will play back the steps you have reached but without repetition of verses / ayat.
    1. Setting of daily goal (aka Daily Wird ورد):
        1. After finishing number of suras (Applicable for short suras)
        1. After finishing number of pages (Applicable for long suras)
        1. The user sets both a target number of Suras and a target number of Pages, and chooses whether to stop at whichever target is reached first (Minimum) or last (Maximum). Examples:
            * Suras = 3, Pages = 5, but the 3 suras are very short (they fit in 1 page), so the minimum option will be 1 page and the maximum option will be 5 pages.
            * Suras = 3, Pages = 5, but the 3 suras are very long (they fit in 40 pages), so the minimum option will be 5 pages and the maximum option will be 40 pages.

### Daily goal (aka Daily Wird ورد) achievements

1. Track the daily goals achieved.
1. Share daily goals achieved as an image file that can be sent on WhatsApp.

## App 2: Audio Analyzer [Folder: src-audio-analyzer]

The purpose of this app is to analyze the audio files and generate pause pointers for long verses / ayat in order to break them down into smaller segments.

1. Gradual download all audio files for a specific reader (sheikh), with resume support in case of download interruption.
1. Analyze the audio files and generate pause pointers for long verses / ayat.
1. Save the pause pointers in a file.
1. Integrate the pause pointers file into the mobile app via manual integration of the generated file (JSON file) unto the mobile app during the build process.


# Technical features

1. API Integration with quran audio sources such as: 
    * Everayah.com (https://everyayah.com/data/)
    * Quran.com (https://api.quran.com/api/v4/)
    * Alquran.cloud (https://api.alquran.cloud/v1/)

# Current Limitations
1. Plan generation only supports 1 Juz selection. You cannot select Suras for the plan, and you cannot select more than 1 Juz. But you can generate multiple plans.
1. Only Arabic and English support for interface language.

# Future Enhancements
1. Add more user interface languages.
1. Host generated long ayas pause pointers files on a server, and allow in-app download of the updated pause pointers from the server.
1. Allow user to export and share memorization plan settings, and import them from others.


# Development notes

## Dev Tools on a Windows machine

### Mobile App (Expo react native)

1. Git
1. Node JS
    1. Configure powershell execution policy: `Set-ExecutionPolicy RemoteSigned`
    1. Install Expo: npm i -g expo-cli
    1. Install dependencies: npm i
1. Visual Studio Code
1. Java JDK
1. Android Studio
1. (Optional) AI tool (Antigravity, etc.)


### Audio Analyzer (C# Console App)

1. Git
1. Visual Studio
1. .NET 8.0
1. Nuget:
    1. NAudio
