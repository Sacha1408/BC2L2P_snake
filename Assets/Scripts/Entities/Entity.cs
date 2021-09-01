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

    private void OnTriggerEnter()
    {
        // DED
        Debug.Log("ded");
    }
}
