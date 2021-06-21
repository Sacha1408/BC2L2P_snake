using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Dès le début, le snake est en mouvement
    // on initialise dans une direction en fonction du niveau dans lequel on est
    // DONC variable publique qui est changée en fonction du niveau

    public Vector3 initDir;



    // Start is called before the first frame update
    void Start()
    {
    

    }

    // Update is called once per frame
    void Update()
    {

    // le snake ne peut pas aller dans la direction dans laquelle il va déjà (ne change rien)

    // switch case selon la direction dans laquelle il se déplace déjà
    // on pourrait aussi ôter chaque "if" de lorsque direction actuelle = direction demandée

    //Vector3 currentDir = new Vector3 (this.transform.forward + this.transform.right) ;
        Debug.Log(transform.forward);
        Debug.Log(transform.right);
        // cas direction actuelle = haut
        //switch (currentDir) { 
        // si direction demandée = gauche
            
            // si direction demandée = droite
        //}


        // cas direction actuelle = bas

            // si direction demandée = gauche

            // si direction demandée = droite


        // cas direction actuelle = gauche

            // si direction demandée = haut

            // si direction demandée = bas


        // cas direction actuelle = droite

            // si direction demandée = haut

            // si direction demandée = bas


        // default (même direction ou direction opposée)

            // ne rien faire




    }
}
