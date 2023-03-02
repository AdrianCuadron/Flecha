using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject player;
    private float posX;
    private float posY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //posY = player.transform.position.y;
        if (player != null)
        {
            transform.position = new Vector3(player.transform.position.x, 0, transform.position.z);
        }
        
    }
}
