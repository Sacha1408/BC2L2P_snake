using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    // Entités
    // Factory d'entités :
    // - Obstacles (murs + obstacles)
    // - Ennemis
    // - Queue du snake
    // - Bonus

    public Collider collider; // composant de collision
    public Transform transform; // positionnement dans l'espace
    public Sprite sprite; // sprite de l'entité

    public Entity(Collider c, Transform t, Sprite s) { // constructeur
        collider = c;
        transform = t;
        sprite = s;
    }

    private void OnTriggerEnter()
    {
        // DED
        Debug.Log("ded");
    }
}
