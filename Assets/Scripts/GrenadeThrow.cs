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
            GrenadeThrowForward();
        }
    }

    private void GrenadeThrowForward()
    {
        GameObject grenade = Instantiate(grenadePrefab, transform.position, transform.rotation);
        Rigidbody rigidbody = grenade.GetComponent<Rigidbody>();
        rigidbody.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
    }
}
