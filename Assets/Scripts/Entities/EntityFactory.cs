using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EntityFactory
{

    public static Entity CreateEntity(string type, Collider c, Transform t, Sprite s)
    {
        Entity e;

        switch (type)
        {
            case "Obstacle":
                e = new Obstacle(c, t, s);
                break;

            case "Enemy":
                e = new Enemy(c, t, s);
                break;

            case "Tail":
                e = new SnakeTail(c, t, s);
                break;

            default :
                Debug.LogError("Entité de mauvais type !");
                return null;
        }
        return e;
    }
}
