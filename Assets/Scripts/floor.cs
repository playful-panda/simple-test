using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    private Transform body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = new Vector3(0, 1, 0);
        body.Rotate(rotation);

    }
}
