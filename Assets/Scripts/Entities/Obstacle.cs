using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : Entity 
{

    // Constructeur reprenant le constructeur de l'entité
    public Obstacle(Vector3 p) : base() {}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("in collision");

        // Si c'est une collision avec le joueur
        if (collision.gameObject.tag == "Player")
        {
            // Game over
            Debug.Log("Game over");

            // On arrête le temps
            Time.timeScale = 0f;
        }
    }
    private void OnTriggerEnter(Collider c)
    {
        Debug.Log("in trigger");

        // Si c'est une collision avec le joueur
        if (c.gameObject.tag == "Player")
        {
            // Game over
            Debug.Log("Game over");

            // On arrête le temps
            Time.timeScale = 0f;
        }
    }
}
