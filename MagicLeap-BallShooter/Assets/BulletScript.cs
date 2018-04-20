using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{




    public GameObject Particles;
    bool _collisionDone;


    void OnCollisionEnter(Collision collision)
    {
        if (!_collisionDone)
        {
            Debug.Log(collision.gameObject.name);
            Instantiate(Particles, collision.contacts[0].point, transform.rotation);
            _collisionDone = true;
        }
    }
}
