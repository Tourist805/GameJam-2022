using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float _power = 10.0f, _radius = 10.0f, _upForce = 0.5f;

    public void Explode()
    {
        Vector3 explosionPosition = this.transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, _radius);

        foreach (Collider c in colliders)
        {
            Rigidbody rigidbody = c.GetComponent<Rigidbody>();
            if (rigidbody != null)
            {
                rigidbody.AddExplosionForce(_power, explosionPosition, _radius, _upForce, ForceMode.Impulse);
            }

        }
    }
}
