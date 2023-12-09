using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("Enable");
    }

    private void Start()
    {
        Debug.Log("Start");
    }

    private void OnDisable()
    {
        Debug.Log("Disable");
    }

    //private void Update()
    //{

    //}
}
