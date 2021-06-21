using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = playerPos.position + new Vector3(0f, 10f, 0f);
        transform.position = Vector3.Lerp(transform.position, pos, 0.1f);
    }

    public Transform playerPos;
}
