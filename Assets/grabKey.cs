using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grabKey : MonoBehaviour
{

    public GameObject key;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = key.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        print(Vector3.Distance(transform.position, key.transform.position));
        if(Vector3.Distance(transform.position, key.transform.position) < 0.4f)
        {
            Vector3 dir = Vector3.Normalize(transform.position - key.transform.position);

            rb.AddForce(dir * 7f, ForceMode.Force);
        }
    }
}
