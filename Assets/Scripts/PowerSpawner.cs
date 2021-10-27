using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpawner : MonoBehaviour
{

    public GameObject powerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakePower", 15f, 15f);
    }

    void MakePower()
    {
        Instantiate(powerPrefab, new Vector3(Random.Range(-8f, 8f), 6, 0), Quaternion.identity);
    }
}
