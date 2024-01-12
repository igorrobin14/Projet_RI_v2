using UnityEngine;

public class VaultGate : MonoBehaviour
{
    public Transform wheelTransform;
    public Transform doorTransform;
    public float rotationMultiplier = 1.0f;
    public float minTranslation = -1.0f;
    public float maxTranslation = 1.0f;

    private Quaternion initialWheelRotation;

    private void Start()
    {
        if (wheelTransform == null || doorTransform == null)
        {
            Debug.LogError("Verifier que les transforms sont mis");
            enabled = false;
            return;
        }

        initialWheelRotation = wheelTransform.rotation;
    }

    private void Update()
    {
    
        Quaternion rotationChange = wheelTransform.rotation * Quaternion.Inverse(initialWheelRotation);

        float rotationAngle = rotationChange.eulerAngles.magnitude;
        float expectedTranslation = rotationAngle * rotationMultiplier;

        Vector3 newPosition = doorTransform.position + doorTransform.up * expectedTranslation;
        newPosition.y = Mathf.Clamp(newPosition.y, minTranslation, maxTranslation);
        doorTransform.position = newPosition;

        initialWheelRotation = wheelTransform.rotation;
    }
}
