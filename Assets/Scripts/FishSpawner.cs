using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public static FishSpawner instance;
    public GameObject[] fishies;

    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        } 
        else
        {
            if (instance != this)
                Destroy(gameObject);
        }
    }

    public void SpawnNewFish()
    {
        int index = Random.Range(0, fishies.Length);
        Instantiate(fishies[index], new Vector3(-10, Random.Range(-4, 4), 0), Quaternion.identity);
    }
}
