using AVFoundation;
using JoesBurgerStore.Dependencies;
using JoesBurgerStore.iOS.DependencyImplementation;

[assembly: Xamarin.Forms.Dependency(typeof(TextToSpeechImplementation))]
namespace JoesBurgerStore.iOS.DependencyImplementation
{
    public class TextToSpeechImplementation : ITextToSpeech
    {
        public void Read(string text)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();

            var speechUtterance = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };

            speechSynthesizer.SpeakUtterance(speechUtterance);
        }
    }
}