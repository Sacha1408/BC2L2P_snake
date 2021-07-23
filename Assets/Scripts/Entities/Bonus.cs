using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : Entity

{

    public Bonus(Collider c, Transform t, Sprite s) : base(c, t, s) { }

    //override collider pour gagner des points au lieu de mourir
}
