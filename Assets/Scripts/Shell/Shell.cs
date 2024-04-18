using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    public GameObject explosion;

    void OnCollisionEnter(Collision collision){
        Instantiate(explosion, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
