using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] groundToSpawn;
    float zPosition = 26.516f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(SpawnGround());
        }
    }

    IEnumerator SpawnGround()
    {
        int n = Random.Range(0, groundToSpawn.Length);
        Instantiate(groundToSpawn[n], new Vector3 (0, 0, zPosition), Quaternion.identity);
        zPosition += 26.516f;
        yield return new WaitForSeconds(1);
    }
}
