using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    [SerializeField] float LeftForce = 10f;
    [SerializeField] float DownForce = 10f;

    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        var randomSpeedMod = Random.Range(0.5f, 1.5f);
        _rigidbody.velocity = new Vector2(randomSpeedMod * -LeftForce, randomSpeedMod * -DownForce);
    }

    // Update is called once per frame
    void Update()
    {
    }
}