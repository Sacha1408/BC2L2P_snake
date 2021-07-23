using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : Entity
{
    // Constructeur reprenant le constructeur de l'entité
    public SnakeTail(Collider c, Transform t, Sprite s) : base(c, t, s) { }

    public void move()
    {
        // Suit la tête du serpent
    }
}
