using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundManager : MonoBehaviour
{
    [SerializeField] int destroyTimer;

    void Awake()
    {
        Object.Destroy(gameObject, destroyTimer);
    }
}
