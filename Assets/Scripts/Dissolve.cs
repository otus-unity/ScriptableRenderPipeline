using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    [SerializeField] float value = 1.0f;
    Material material;

    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    void Update()
    {
        material.SetFloat("Vector1_75e3bdadd9cf47b2a676274a258a178e", value);
    }
}
