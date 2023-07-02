using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tagging : MonoBehaviour
{
    public Transform target; // Reference to the player's transform
    public float moveSpeed = 5f; // Speed at which the object chases the player

    private void Update()
    {
        // Check if the target (player) is available
        if (target == null)
        {
            Debug.LogWarning("Target (player) is not assigned!");
            return;
        }

        // Calculate the direction towards the player
        Vector3 direction = target.position - transform.position;
        Vector3 viewPoint = new Vector3(0, target.transform.position.y, 0);
        transform.LookAt(viewPoint);

        // Normalize the direction vector
        direction.Normalize();

        // Calculate the object's movement for this frame
        Vector3 movement = direction * moveSpeed * Time.deltaTime;

        // Move the object towards the player
        transform.position += movement;
    }
}
