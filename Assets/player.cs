using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour //MonoBehaviour is component
{
    private Rigidbody2D _rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.AddForce(Vector2.up * 10,ForceMode2D.Impulse);
        }
    }
}
