using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : Entity
{
    Vector2 oldPos; // Pour éviter de générer le bonus 2 fois au même endroit
    private AudioSource bonusSound;

    private void Start()
    {
        bonusSound = GameObject.FindGameObjectWithTag("score").GetComponent<AudioSource>();
    }

    public Bonus(Vector3 p) : base() {
        Instantiate((GameObject)Resources.Load("Entities/Bonus"), p, new Quaternion(0, 0, 0, 0));
    }

    //override collider pour gagner des points au lieu de mourir
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Debug.Log("POINTS");
            Player p = other.GetComponent<Player>();
            p.gm.scoreUp(100);
            bonusSound.Play();
            p.grow();

            regenerate();
            Destroy(gameObject);
        }
    }

    private void regenerate()
    {
        // A modifier pour eviter l'apparition du bonus dans les obstacles
        Vector2 pos = new Vector2(Random.Range(0, (int)GameManager.size.x), Random.Range(0, (int)GameManager.size.y));
        
        if(pos == oldPos)
        {
            regenerate();
        }
        else
        {
            Instantiate((GameObject)Resources.Load("Entities/Bonus"), pos, new Quaternion(0, 0, 0, 0));
        }
    }
}
