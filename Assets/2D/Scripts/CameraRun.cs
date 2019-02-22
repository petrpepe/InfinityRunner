using System;
using UnityEngine;

public class CameraRun : MonoBehaviour
{
    public Transform player;
    private void Start()
    {
        
    }

    private void Update()
    {
        transform.position = new Vector3(player.position.x + 6, 0, -10);
    }
}
