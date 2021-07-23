using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : Entity 
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    // Constructeur reprenant le constructeur de l'entité
    public Obstacle(Collider c, Transform t, Sprite s) : base(c, t, s) {}
}
