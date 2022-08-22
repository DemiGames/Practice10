using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringPlatform : MonoBehaviour
{
    public float startTime;
    public float timeToBounce;
    void Start()
    {
        GetComponent<Rigidbody>();
        timeToBounce = startTime;
    }

    void Update()
    {
        timeToBounce -= Time.deltaTime;
        if (timeToBounce <= 0)
        {
            timeToBounce = startTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Rigidbody>().AddForce(0, 50, 0, ForceMode.Impulse);
    }
}
