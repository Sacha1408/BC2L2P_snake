using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Constructeur reprenant le constructeur de l'entit�
    public Enemy(Vector3 p, Sprite s) : base(p, s) { }
}
