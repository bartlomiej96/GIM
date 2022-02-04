using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather : MonoBehaviour
{
    [SerializeField] ParticleSystem snow;
    [SerializeField] ParticleSystem rain;
    // Start is called before the first frame update
    void Start()
    {
        snow.Stop();
        rain.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("n"))
        {
            if (snow.isEmitting) snow.Stop();
            else snow.Play();
        }
        if (Input.GetKeyDown("m"))
        {
            if (rain.isEmitting) rain.Stop();
            else rain.Play();
        }
    }
}
