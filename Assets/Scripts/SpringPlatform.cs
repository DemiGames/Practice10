using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringPlatform : MonoBehaviour
{
    public float startTime;
    public float timeToBounce;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        timeToBounce = startTime;
    }

    void Update()
    {
        timeToBounce -= Time.deltaTime;
        if (timeToBounce <= 0)
        {
            SpringSmthn();
            timeToBounce = startTime;
        }
    }
    private void SpringSmthn()
    {
        rb.AddForce(0, 100, 0, ForceMode.Impulse);
    }
}
