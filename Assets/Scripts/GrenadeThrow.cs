using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrow : MonoBehaviour
{
    [SerializeField] private float throwForce = 50f;
    [SerializeField] private GameObject grenadePrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GrenadeThrowForvard();
        }
    }

    void GrenadeThrowForvard()
    {

    }
}
