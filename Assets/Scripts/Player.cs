using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager gm;

    public CharacterController controller;
    public float speed = 1f;
    public int size = 2;                    // Taille de la queue du serpent
    public GameObject tailPart;             // Queue du serpent
    public GameObject tailEnd;              // Bout de la queue
    public GameObject tailTurn;             // Queue qui tourne

    private List<Vector3> tailPosBuffer;    // historique des positions
    private List<Quaternion> tailRotBuffer; // historique des rotations
    private List<GameObject> tailObjects;   // liste des parties de la queue du serpent
    private List<int> turns;                // Liste des virages du serpent (afin d'afficher les virages avec la queue)

    private float interval;                 // Temps entre deux déplacements
    private float remainingBeforeMove;      // Temps restant avant le prochain déplacement
    private string arrow = "";              // Fixe la direction choisie par l'utilisateur
    private int choice = 0;                 // Indique si un choix de direction a été fait ou non : 0 si pas de virage, 1 si virage à gauche, 2 si virage à droite

    // Start is called before the first frame update
    void Start()
    {
        tailPosBuffer = new List<Vector3>();
        tailRotBuffer = new List<Quaternion>();
        tailObjects = new List<GameObject>();
        turns = new List<int>();

        interval = 1 / speed;
        remainingBeforeMove = interval;
    }

    public void SetArrow(string arrow)
    {
        this.arrow = arrow;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(remainingBeforeMove);

        float direction = transform.rotation.eulerAngles.z;

        switch (direction)
        {

            // Si le Snake est orienté vers le haut
            case 0:
                //Debug.Log("haut");

                // Si le joueur appuie sur le bouton 'haut'
                // Ne rien faire

                // Si le joueur appuie sur le bouton 'bas'
                // Ne rien faire

                // Si le joueur appuie sur le bouton 'gauche'
                if ((Input.GetKey("left") || this.arrow == "left") && choice == 0)
                {
                    transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
                    // Un déplacement a été choisi, on empeche de le refaire
                    choice = 1;
                }

                // Si le joueur appuie sur le bouton 'droite'
                if ((Input.GetKey("right") || this.arrow == "right") && choice == 0)
                {
                    transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
                    // Un déplacement a été choisi, on empeche de le refaire
                    choice = 2;
                }

                break;

            // Si le Snake est orienté vers le bas
            case 180:
                //Debug.Log("bas");

                // Si le joueur appuie sur le bouton 'haut'
                // Ne rien faire

                // Si le joueur appuie sur le bouton 'bas'
                // Ne rien faire

                // Si le joueur appuie sur le bouton 'gauche'
                if ((Input.GetKey("left") || this.arrow == "left") && choice == 0)
                {
                    transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
                    // Un déplacement a été choisi, on empeche de le refaire
                    choice = 2;
                }
                // Si le joueur appuie sur le bouton 'droite'
                if ((Input.GetKey("right") || this.arrow == "right") && choice == 0)
                {
                    transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
                    // Un déplacement a été choisi, on empeche de le refaire
                    choice = 1;
                }

                break;

            // Si le Snake est orienté vers la gauche
            case 90:
                //Debug.Log("gauche");

                // Si le joueur appuie sur le bouton 'haut'
                if ((Input.GetKey("up") || this.arrow == "up") && choice == 0)
                {
                    transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
                    // Un déplacement a été choisi, on empeche de le refaire
                    choice = 2;
                }
                // Si le joueur appuie sur le bouton 'bas'
                if ((Input.GetKey("down") || this.arrow == "down") && choice == 0)
                {
                    transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
                    // Un déplacement a été choisi, on empeche de le refaire
                    choice = 1;
                }
                // Si le joueur appuie sur le bouton 'gauche'
                // Ne rien faire

                // Si le joueur appuie sur le bouton 'droite'
                // Ne rien faire


                break;

            // Si le Snake est orienté vers la droite
            case 270:
                //Debug.Log("droite");

                // Si le joueur appuie sur le bouton 'haut'
                if ((Input.GetKey("up") || this.arrow == "up") && choice == 0)
                {
                    transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
                    // Un déplacement a été choisi, on empeche de le refaire
                    choice = 1;
                }
                // Si le joueur appuie sur le bouton 'bas'
                if ((Input.GetKey("down") || this.arrow == "down") && choice == 0)
                {
                    transform.Rotate(0.0f, 0.0f, -90.0f, Space.Self);
                    // Un déplacement a été choisi, on empeche de le refaire
                    choice = 2;
                }
                // Si le joueur appuie sur le bouton 'gauche'
                // Ne rien faire

                // Si le joueur appuie sur le bouton 'droite'
                // Ne rien faire

                break;

            default:
                //Debug.Log(transform.rotation.eulerAngles);
                break;
        }

        // Ajout déplacement par tile
        if (remainingBeforeMove <= 0)
        {
            turns.Insert(0, choice);

            // Buffer gardant les précédentes positions du snake
            tailPosBuffer.Insert(0, transform.position); 
            tailRotBuffer.Insert(0, transform.rotation);

            // D�placement tout droit
            transform.position+=transform.up; //deltatime -> ind�pendant du framerate
            remainingBeforeMove = interval;
            
            // Suppression du dernier élément de la liste
            if(tailPosBuffer.Count >= size + 1)
            {
                tailPosBuffer.RemoveAt(tailPosBuffer.Count - 1);
                tailRotBuffer.RemoveAt(tailRotBuffer.Count - 1);
                tailObjects.RemoveAt(tailObjects.Count - 1);
                turns.RemoveAt(turns.Count - 1);
            }

            for (int i = 0; i < tailPosBuffer.Count; i++)
            {
                GameObject g;
                // Si c'est le dernier de la liste, on instancie de bout de la queue
                if (i == tailPosBuffer.Count - 1)
                {
                    g = Instantiate(tailEnd, tailPosBuffer[i], tailRotBuffer[i]);
                }
                else if (turns[i] == 1)
                {
                    // Si c'est un virage à gauche, on instancie la queue en virage
                    g = Instantiate(tailTurn, tailPosBuffer[i], tailRotBuffer[i]);
                    g.transform.Rotate(0.0f, 0.0f, -180.0f, Space.Self);
                }else if (turns[i] == 2)
                {
                    // Si c'est un virage à droite, on instancie la queue en virage
                    g = Instantiate(tailTurn, tailPosBuffer[i], tailRotBuffer[i]);
                    g.transform.Rotate(0.0f, 0.0f, 90.0f, Space.Self);
                }
                else
                {// Sinon, on instancie la queue normale
                    g = Instantiate(tailPart, tailPosBuffer[i], tailRotBuffer[i]);
                }
                tailObjects.Insert(0, g);
                Destroy(g, interval+0.02f); // On détruit cet élément au prochain déplacement, + 20ms pour éviter les clignotements
            }

            // On se déplace, donc on autorise à faire un nouveau choix
            choice = 0;

            gm.scoreUp(10);
        }
        else
        {
            remainingBeforeMove -= Time.deltaTime;
        }
    }

    public void grow()
    {
        size++;
    }

    public void die()
    {
        foreach(GameObject g in tailObjects)
        {
            Destroy(g);
        }
        Destroy(gameObject);
    }
}
