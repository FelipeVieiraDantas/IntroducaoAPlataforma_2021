using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorgBolinha : MonoBehaviour
{
    Rigidbody fisica;

    // Start is called before the first frame update
    void Start()
    {
        fisica = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        fisica.AddForce(0, 0, 10);
    }
}
