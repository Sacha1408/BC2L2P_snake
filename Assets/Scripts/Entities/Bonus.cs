using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : Entity

{

    public Bonus(Vector3 p, Sprite s) : base(p, s) { }

    //override collider pour gagner des points au lieu de mourir
}
