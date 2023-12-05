using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyrespaw : MonoBehaviour
{

    public Transform xnegativo;
    public Transform xpositivo;
    public Transform ynegativo;
    public Transform ypositivo;
    public GameObject enemy;
    // Start is called before the first frame update
    private void Awake()
    {
       
    }
    void Start()
    {
       

        Invoke("creator", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void creator()
    {
        Invoke("creator", 3);
        Vector2 posit = new Vector2(Random.Range(xnegativo.position. x,xpositivo.position. x), Random.Range(ynegativo.position.y, ypositivo.position.y));
        Instantiate(enemy, posit, transform.rotation);
        
    }
}
