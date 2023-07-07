using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    public GameObject[] obsticlePrefab;
    
    private float startDelay = 2f;
    private float repeatRate = 2f;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObsticle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnObsticle()
    {
        int obsticleIndex = Random.Range(0, obsticlePrefab.Length);
        Vector3 spawnPos = new Vector3(25, 0, 0);
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obsticlePrefab[obsticleIndex], spawnPos, obsticlePrefab[obsticleIndex].transform.rotation);
        }
    }
}
