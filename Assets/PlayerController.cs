using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int speed;

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (transform.position.x == -3)
            {
                transform.position = new Vector3(0,0, transform.position.z);
            }
            else if (transform.position.x == 0) 
            {
                transform.position = new Vector3(3,0, transform.position.z);
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (transform.position.x == 3)
            {
                transform.position = new Vector3(0, 0, transform.position.z);
            }
            else if (transform.position.x == 0) 
            { 
                transform.position = new Vector3(-3, 0, transform.position.z);
            }


    }
}
}