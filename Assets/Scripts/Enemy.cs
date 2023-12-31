using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    private Rigidbody enemyRBody;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        enemyRBody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRBody.AddForce(lookDirection * speed);
    }
}
