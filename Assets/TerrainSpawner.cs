using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainSpawner : MonoBehaviour
{
    [SerializeField] GameObject ground;
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
        Instantiate(ground, new Vector3 (0, 0, zPosition), Quaternion.identity);
        zPosition += 26.516f;
        yield return new WaitForSeconds(1);
    }
}
