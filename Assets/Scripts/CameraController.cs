using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // The camera should follow the Player as it moves. In other words, when the player moves, the camera’s Transform position should also change relative to the Player
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = player.transform.position + offset;
        transform.position = newPosition;
    }
}
