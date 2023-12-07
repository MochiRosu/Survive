using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public GameObject destructionPrefab; // Drag your prefab here in the Inspector

    // Adjust this distance based on how close you want the player to be for interaction
    public float interactionDistance = 2f;

    void Update()
    {
        // Check for interaction button (e.g., "F" key)
        if (Input.GetButtonDown("Interact"))
        {
            TryInteract();
        }
    }

    void TryInteract()
    {
        // Check if the player is within the interaction distance
        Collider playerCollider = GetPlayerCollider();
        if (playerCollider != null && playerCollider.GetType() == typeof(CapsuleCollider) &&
            Vector3.Distance(transform.position, playerCollider.transform.position) <= interactionDistance)
        {
            DestroyObject();
        }
    }

    Collider GetPlayerCollider()
    {
        // Find the player with the "Player" tag
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        // Check if the player exists and has a collider
        if (player != null)
        {
            Collider playerCollider = player.GetComponent<Collider>();
            return playerCollider;
        }

        return null;
    }

    void DestroyObject()
    {
        // Instantiate a prefab at the current object's position
        Instantiate(destructionPrefab, transform.position, Quaternion.identity);

        // Destroy the current object
        Destroy(gameObject);
    }
}
