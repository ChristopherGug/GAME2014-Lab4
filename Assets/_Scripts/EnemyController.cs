using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    private float direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        CheckBounds();
    }

    private void Move()
    {
        transform.position += new Vector3(horizontalSpeed * direction * Time.deltaTime, 0.0f, 0.0f);
    }

    private void CheckBounds()
    {
        if (transform.position.x >= horizontalBoundary)
        {
            direction = -direction;
        }
        if (transform.position.x <= -horizontalBoundary)
        {
            direction = -direction;
        }
    }
}
