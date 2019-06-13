using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpawner : MonoBehaviour
{
    public Transform spawnPos;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            Pool.SpawnObject("spawnee1").transform.position = spawnPos.position;
        }

        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            Pool.SpawnObject("spawnee2").transform.position = spawnPos.position;
        }

        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            Pool.SpawnObject("spawnee3").transform.position = spawnPos.position;
        }
    }
}
