using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.IO;

namespace TTSBS
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = File.ReadAllText(@"D:\vs\TTSBS\1984.txt");

            List<string> word = text.Split().ToList();

            string words = string.Join("\n", word);

            Console.WriteLine($"{words}");

            var synthesizer = new SpeechSynthesizer();

            synthesizer.SetOutputToDefaultAudioDevice();

            synthesizer.SelectVoiceByHints(VoiceGender.Male);


            synthesizer.Speak(text);


            Console.ReadKey();
        }
    }
}

