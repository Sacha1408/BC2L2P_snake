using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : Entity 
{

    // Constructeur reprenant le constructeur de l'entit�
    public Obstacle(Vector3 p) : base() {}
    public GameOverScreen GameOverScreen;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("in collision");

        // Si c'est une collision avec le joueur
        if (collision.gameObject.tag == "Player")
        {
            // D�clenche la m�thode GameOver du script GameManager
            FindObjectOfType<GameManager>().GameOver();

            collision.gameObject.GetComponent<Player>().die();
        }
    }
}
