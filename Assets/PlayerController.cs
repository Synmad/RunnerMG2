using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Build.Content;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int speed;

    GameObject gamemanager;
    TerrainSpawner terrainspawner;
    SceneController scenecontroller;
    ScoreController scorecontroller;

    private void Awake()
    {
        gamemanager = GameObject.Find("GameManager");
        terrainspawner = gamemanager.GetComponent<TerrainSpawner>();
        scenecontroller = gamemanager.GetComponent<SceneController>();
        scorecontroller = gamemanager.GetComponent<ScoreController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Check"))
        {
            terrainspawner.StartSpawnGround();
        }

        if (other.CompareTag("Obstacle"))
        {
            scenecontroller.LoadGameOver();
        }

        if (other.CompareTag("Score"))
        {
            scorecontroller.IncreaseScore(10);
        }
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (transform.position.x == -3)
            {
                transform.position = new Vector3(0, transform.position.y, transform.position.z);
            }
            else if (transform.position.x == 0)
            {
                transform.position = new Vector3(3, transform.position.y, transform.position.z);
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (transform.position.x == 3)
            {
                transform.position = new Vector3(0, transform.position.y, transform.position.z);
            }
            else if (transform.position.x == 0)
            {
                transform.position = new Vector3(-3, transform.position.y, transform.position.z);
            }
        }
    }
}