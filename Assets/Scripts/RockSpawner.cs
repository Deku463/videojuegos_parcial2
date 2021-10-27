using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{

    public GameObject rockPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeRock", 1f, 1f);
    }

    void MakeRock()
    {
        Instantiate(rockPrefab, new Vector3(Random.Range(-8f, 8f), 6, 0), Quaternion.identity);
    }
}
