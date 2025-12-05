using UnityEngine;

namespace Whisper.Samples {
  [CreateAssetMenu(fileName = "JumpCommand", menuName = "Voice Commands/Jump")]
  public class JumpCommand : VoiceCommand {
    public float jumpForce = 5f;

    public override void Execute(GameObject target) {
      if (target == null)
        return;
      var rb = target.GetComponent<Rigidbody>();
      if (rb != null)
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
  }
}