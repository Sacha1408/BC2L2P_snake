using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // D�s le d�but, le snake est en mouvement
    // on initialise dans une direction en fonction du niveau dans lequel on est
    // DONC variable publique qui est chang�e en fonction du niveau

    public Vector3 initDir;



    // Start is called before the first frame update
    void Start()
    {
    

    }

    // Update is called once per frame
    void Update()
    {

    // le snake ne peut pas aller dans la direction dans laquelle il va d�j� (ne change rien)

    // switch case selon la direction dans laquelle il se d�place d�j�
    // on pourrait aussi �ter chaque "if" de lorsque direction actuelle = direction demand�e

    //Vector3 currentDir = new Vector3 (this.transform.forward + this.transform.right) ;
        Debug.Log(transform.forward);
        Debug.Log(transform.right);
        // cas direction actuelle = haut
        //switch (currentDir) { 
        // si direction demand�e = gauche
            
            // si direction demand�e = droite
        //}


        // cas direction actuelle = bas

            // si direction demand�e = gauche

            // si direction demand�e = droite


        // cas direction actuelle = gauche

            // si direction demand�e = haut

            // si direction demand�e = bas


        // cas direction actuelle = droite

            // si direction demand�e = haut

            // si direction demand�e = bas


        // default (m�me direction ou direction oppos�e)

            // ne rien faire




    }
}
