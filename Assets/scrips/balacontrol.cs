using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balacontrol : MonoBehaviour
{
    private Rigidbody2D _comrigg;
    public int velocy = 10;
    private float hori, verty;
    // Start is called before the first frame update
    private void Awake()
    {
        _comrigg = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private void FixedUpdate()
    {
        _comrigg.velocity = new Vector2(0,transform.position.y+velocy);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="enemigo")
        {
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "pared")
        {
            Destroy(this.gameObject);
        }
    }
}
