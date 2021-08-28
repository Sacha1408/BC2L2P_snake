using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 1f;

    private float interval;
    private float remainingBeforeMove;
    private bool choice = false;

    // Start is called before the first frame update
    void Start()
    {
        interval = 1 / speed;
        remainingBeforeMove = interval;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(remainingBeforeMove);

        float direction = transform.rotation.eulerAngles.z;

        switch (direction)
        {

            // Si le Snake est orienté vers le haut
            case 0:
                Debug.Log("haut");

                // Si le joueur appuie sur le bouton 'haut'
                // Ne rien faire

                // Si le joueur appuie sur le bouton 'bas'
                // Ne rien faire

                // Si le joueur appuie sur le bouton 'gauche'
                if (Input.GetKey("left") && !choice)
                {
                    transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
                    // Un déplacement a été choisi, on empeche de le refaire
                    choice = true;
                }

                // Si le joueur appuie sur le bouton 'droite'
                if (Input.GetKey("right") && !choice)
                {
                    transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
                    // Un déplacement a été choisi, on empeche de le refaire
                    choice = true;
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
                if (Input.GetKey("left") && !choice)
                {
                    transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
                    // Un déplacement a été choisi, on empeche de le refaire
                    choice = true;
                }
                // Si le joueur appuie sur le bouton 'droite'
                if (Input.GetKey("right") && !choice)
                {
                    transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
                    // Un déplacement a été choisi, on empeche de le refaire
                    choice = true;
                }

                break;

            // Si le Snake est orienté vers la gauche
            case 90:
                Debug.Log("gauche");

                // Si le joueur appuie sur le bouton 'haut'
                if (Input.GetKey("up") && !choice)
                {
                    transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
                    // Un déplacement a été choisi, on empeche de le refaire
                    choice = true;
                }
                // Si le joueur appuie sur le bouton 'bas'
                if (Input.GetKey("down") && !choice)
                {
                    transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
                    // Un déplacement a été choisi, on empeche de le refaire
                    choice = true;
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
                if (Input.GetKey("up") && !choice)
                {
                    transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
                    // Un déplacement a été choisi, on empeche de le refaire
                    choice = true;
                }
                // Si le joueur appuie sur le bouton 'bas'
                if (Input.GetKey("down") && !choice)
                {
                    transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
                    // Un déplacement a été choisi, on empeche de le refaire
                    choice = true;
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

        // Ajout déplacement par tile
        if (remainingBeforeMove <= 0)
        {
            // D�placement tout droit
            controller.Move(transform.up); //deltatime -> ind�pendant du framerate
            remainingBeforeMove = interval;
            // On se déplace, donc on autorise à faire un nouveau choix
            choice = false;
        }
        else
        {
            remainingBeforeMove -= Time.deltaTime;
        }

    }
}
