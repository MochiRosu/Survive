using UnityEngine;

public class TreeInteraction : MonoBehaviour
{
    // Adjust this distance based on how close you want the player to be for interaction
    public float interactionDistance = 2f;

    // Drag your prefab here in the Inspector
    public GameObject woodPrefab;

    void Update()
    {
        // Check for interaction button (e.g., "F" key)
        if (Input.GetKeyDown(KeyCode.F))
        {
            TryInteract();
        }
    }

    void TryInteract()
    {
        // Find the player with the "Player" tag
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        // Check if the player exists and is within the interaction distance
        if (player != null && Vector3.Distance(transform.position, player.transform.position) <= interactionDistance)
        {
            Debug.Log("Interacting with the tree!");

            // Instantiate a wood prefab at the tree's position
            Instantiate(woodPrefab, transform.position, Quaternion.identity);

            // Destroy the tree
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Too far away from the tree to interact.");
        }
    }
}
