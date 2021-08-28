using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (transform.rotation.eulerAngles.z){
        // Si le Snake est orienté vers le haut
        case 0:
        Debug.Log("haut");

        // Si le joueur appuie sur le bouton 'haut'
        // Ne rien faire

        // Si le joueur appuie sur le bouton 'bas'
        // Ne rien faire
    
        // Si le joueur appuie sur le bouton 'gauche'
        if (Input.GetKey("left")) {
            transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
        }

        // Si le joueur appuie sur le bouton 'droite'
        if (Input.GetKey("right")) {
            transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
        }

        break;

        // Si le Snake est orienté vers le bas
        case 180:
        Debug.Log("bas");

        // Si le joueur appuie sur le bouton 'haut'
        // Ne rien faire

        // Si le joueur appuie sur le bouton 'bas'
        // Ne rien faire

        // Si le joueur appuie sur le bouton 'gauche'
        if (Input.GetKey("left")) {
            transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
        }
        // Si le joueur appuie sur le bouton 'droite'
        if (Input.GetKey("right")) {
            transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
        }

        break;

        // Si le Snake est orienté vers la gauche
        case 90:
        Debug.Log("gauche");

        // Si le joueur appuie sur le bouton 'haut'
        if (Input.GetKey("up")) {
            transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
        }
        // Si le joueur appuie sur le bouton 'bas'
        if (Input.GetKey("down")) {
            transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
        }
        // Si le joueur appuie sur le bouton 'gauche'
        // Ne rien faire

        // Si le joueur appuie sur le bouton 'droite'
        // Ne rien faire


        break;

        // Si le Snake est orienté vers la droite
        case 270:
        Debug.Log("droite");

        // Si le joueur appuie sur le bouton 'haut'
        if (Input.GetKey("up")) {
            transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
        }
        // Si le joueur appuie sur le bouton 'bas'
        if (Input.GetKey("down")) {
            transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
        }
        // Si le joueur appuie sur le bouton 'gauche'
        // Ne rien faire

        // Si le joueur appuie sur le bouton 'droite'
        // Ne rien faire

        break;

        default:
        Debug.Log(transform.rotation.eulerAngles);

        break;
        }



        // D�placement tout droit
        controller.Move(transform.up * speed * Time.deltaTime); //deltatime -> ind�pendant du framerate
    }
}
