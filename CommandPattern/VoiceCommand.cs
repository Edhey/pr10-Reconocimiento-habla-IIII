using UnityEngine;

namespace Whisper.Samples {
  public abstract class VoiceCommand : ScriptableObject {
    public string[] keywords;

    public bool Matches(string text) {
      if (string.IsNullOrEmpty(text))
        return false;
      var lowerText = text.ToLowerInvariant();

      foreach (var keyword in keywords) {
        if (lowerText.Contains(keyword.ToLowerInvariant()))
          return true;
      }
      return false;
    }

    public abstract void Execute(GameObject target);
  }
}