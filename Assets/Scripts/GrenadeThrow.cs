using UnityEngine;

public class GrenadeThrow : MonoBehaviour
{
    [SerializeField] private float throwForce = 1f;
    [SerializeField] private GameObject grenadePrefab;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
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
