using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    // Entit�s
    // Factory d'entit�s :
    // - Obstacles (murs + obstacles)
    // - Ennemis
    // - Queue du snake
    // - Bonus

    //public Collider2D collider; // composant de collision
    public Vector3 position; // positionnement dans l'espace
    public Sprite sprite; // sprite de l'entit�

    public Entity(Vector3 p, Sprite s) { // constructeur

        //collider = new Collider2D();
        position = p;
        sprite = s;
    }

    private void OnTriggerEnter()
    {
        // DED
        Debug.Log("ded");
    }
}
