using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellExplosion : MonoBehaviour
{
    private ParticleSystem particles;

    void Start(){
        particles = GetComponent<ParticleSystem>();
        particles.Play();
        Destroy(gameObject, particles.main.duration);
    }
}
