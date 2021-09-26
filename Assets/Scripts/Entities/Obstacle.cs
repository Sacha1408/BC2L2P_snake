using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : Entity 
{
    AudioSource s;

    // Constructeur reprenant le constructeur de l'entité
    public Obstacle(Vector3 p) : base() {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("in collision");

        s = GameObject.FindGameObjectWithTag("ui").GetComponent<AudioSource>();

        // Si c'est une collision avec le joueur
        if (collision.gameObject.tag == "Player")
        {
            // Déclenche la méthode GameOver du script GameManager
            FindObjectOfType<GameManager>().GameOver();
            s.Play();
            collision.gameObject.GetComponent<Player>().die();
        }
    }
}
