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
            Debug.LogError("Ensure Wheel Transform and Door Transform are set.");
            enabled = false;
            return;
        }

        initialWheelRotation = wheelTransform.rotation;
    }

    private void Update()
    {
        // Calculate the rotation change since the initial rotation
        Quaternion rotationChange = wheelTransform.rotation * Quaternion.Inverse(initialWheelRotation);

        // Calculate the expected translation based on the rotation change
        float rotationAngle = rotationChange.eulerAngles.magnitude;
        float expectedTranslation = rotationAngle * rotationMultiplier;

        // Move the door based on the expected translation, clamped between min and max values
        Vector3 newPosition = doorTransform.position + doorTransform.up * expectedTranslation;
        newPosition.y = Mathf.Clamp(newPosition.y, minTranslation, maxTranslation);
        doorTransform.position = newPosition;

        // Update the initial rotation for the next frame
        initialWheelRotation = wheelTransform.rotation;
    }
}
