using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    Transform player;

    // Start is called before the first frame update
    // This sets the camera to be parented to the @D player's navigation amd patrol
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }

    
    // Update is called once per frame
    //This is update at every interval, to keep the camera focused on the 2D player
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, player.position.z - 250);
    }
}
