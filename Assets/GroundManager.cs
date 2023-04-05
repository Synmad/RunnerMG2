using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    [SerializeField] int destroyTimer;

    void Start()
    {
        Object.Destroy(gameObject, destroyTimer);
    }

}
