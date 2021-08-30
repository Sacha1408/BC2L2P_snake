using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityFactory : MonoBehaviour
{
    public static void CreateEntity(string type, Vector3 p)
    {
        Entity e;

        switch (type)
        {
            case "obstacle":
                e = new Obstacle(p);
                break;

            case "enemy":
                e = new Enemy(p);
                break;

            case "bonus":
                e = new Bonus(p);
                break;

            default :
                Debug.LogError("Entité de mauvais type !");
                break;
        }
    }
}
