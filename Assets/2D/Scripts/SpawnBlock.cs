using System;
using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
    public GameObject[] obj;
    public float spawnMin = 1f;
    public float spawnMax = 2f;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)], transform.position, Quaternion.identity);
        Invoke("Spawn", UnityEngine.Random.Range(spawnMin, spawnMax));
    }
}

