using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static Vector2 size = new Vector2(9, 9); // TAILLE DU NIVEAU

    public int score = 0;
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        EntityFactory.CreateEntity("bonus", new Vector3(2, 2, 0));
    }

    void FixedUpdate()
    {
        scoreText.text = score.ToString();
    }

    public void scoreUp(int i)
    {
        score += i;
    }
}
