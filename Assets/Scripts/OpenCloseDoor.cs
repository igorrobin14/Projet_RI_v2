using UnityEngine;

public class OpenCloseDoor : MonoBehaviour
{
    public Animator doorAnimator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Set the "character_nearby" parameter to true when the player enters
            doorAnimator.SetBool("character_nearby", true);
            Debug.Log("Player entered the collider. character_nearby set to true.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Reset the "character_nearby" parameter to false when the player leaves
            doorAnimator.SetBool("character_nearby", false);
            Debug.Log("Player left the collider. character_nearby set to false.");
        }
    }

    private void Update()
    {
        // Additional logic can be added here based on your requirements
        // For example, you might want to continuously check conditions or perform calculations.
    }
}