using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpawnee : MonoBehaviour
{
    Rigidbody2D rb;
    public string poolName;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Go();
    }

    private void OnEnable()
    {
        Go();
    }

    private void Go()
    {
        rb.velocity = new Vector2(0.0f, 3.0f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Test_Collector")
        {
            Pool.RemoveObject(this.gameObject, poolName);
        }
    }
}
