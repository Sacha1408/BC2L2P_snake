using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public float score;
    private Text displayedText;

    // Start is called before the first frame update
    void Start()
    {
        this.displayedText = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //this.displayedText.text = score.ToString();
    }
}
