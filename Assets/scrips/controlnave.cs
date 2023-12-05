using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlnave : MonoBehaviour
{
    private Rigidbody2D _comporig;
    public int velicity=5;
    private float hori,verti;
    public GameObject bala;

    // Start is called before the first frame update
    private void Awake()
    {
        _comporig = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hori = Input.GetAxis("Horizontal");
        verti = Input.GetAxis("Vertical");
        if (Input.GetKeyDown("space")==true)
        {
            Instantiate(bala, transform.position, transform.rotation);
        }
    }
    private void FixedUpdate()
    {
       
        _comporig.velocity = new Vector2(hori * velicity,verti*velicity) ;
    }
}
