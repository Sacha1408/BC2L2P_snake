using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : Entity 
{

    // Constructeur reprenant le constructeur de l'entité
    public Obstacle(Vector3 p) : base() {}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("in collision");

        // Si c'est une collision avec le joueur
        if (collision.gameObject.tag == "Player")
        {
            // Game over
            Debug.Log("Game over");

            collision.gameObject.GetComponent<Player>().die();

            // On arrête le temps
            Time.timeScale = 0f;
        }
    }
}
