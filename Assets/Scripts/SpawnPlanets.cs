using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlanets : MonoBehaviour {


    public Transform planetPrefab;
    public float spawnRate = 6f; // float value = 2.0 seconds

    private void SpawnAllPlanets()
    {


        Vector3 spawnPosition;

            spawnPosition = new Vector3(Random.Range(-4, 4),
                                        transform.position.y,
                                        transform.position.z);

        var planetsTransform = Instantiate(planetPrefab) as Transform;

        planetsTransform.position = spawnPosition;
    }


}
