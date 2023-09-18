using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRBody;
    public float speed = 3.0f;
    private GameObject focalPoint;

    // Start is called before the first frame update
    void Start()
    {
        playerRBody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRBody.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }
}
