using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Barrier : MonoBehaviour
{

    public ParticleSystem Particle;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) //Activates particle when hitting the sphere collider
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Particle.Play();
            }
        }
}
