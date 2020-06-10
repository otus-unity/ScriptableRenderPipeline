using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateAlpha : MonoBehaviour
{
    public Material material;
    public float value;

    void Update()
    {
        if (material != null)
            material.SetFloat("Vector1_461F0D7B", value);
    }
}
