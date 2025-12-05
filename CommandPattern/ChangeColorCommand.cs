using UnityEngine;

namespace Whisper.Samples {
  [CreateAssetMenu(fileName = "ChangeColorCommand", menuName = "Voice Commands/Change Color")]
  public class ChangeColorCommand : VoiceCommand {
    public Color targetColor = Color.red;

    public override void Execute(GameObject target) {
      if (target == null)
        return;
      var rend = target.GetComponent<Renderer>();
      if (rend == null)
        rend = target.GetComponentInChildren<Renderer>();
      if (rend != null)
        rend.material.color = targetColor;
    }
  }
}