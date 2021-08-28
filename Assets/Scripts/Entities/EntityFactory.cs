using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EntityFactory
{

    public static Entity CreateEntity(string type, Vector3 p, Sprite s)
    {
        Entity e;

        switch (type)
        {
            case "Obstacle":
                e = new Obstacle(p, s);
                break;

            case "Enemy":
                e = new Enemy(p, s);
                break;
/*
            case "Tail":
                e = new SnakeTail(p, s);
                break;
*/
            default :
                Debug.LogError("Entité de mauvais type !");
                return null;
        }
        return e;
    }
}
