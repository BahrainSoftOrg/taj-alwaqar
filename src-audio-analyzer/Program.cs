using NAudio.Wave;

namespace src_audio_analyzer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Audio Analyzer Initialized.");
        Console.WriteLine("NAudio version: " + typeof(WaveFileReader).Assembly.GetName().Version);
    }
}
