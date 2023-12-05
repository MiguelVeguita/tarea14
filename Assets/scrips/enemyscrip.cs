using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyscrip : MonoBehaviour
{
    public Animator _anim;
    private AudioSource _au;
    private Transform _comtra;
    private BoxCollider2D _combox;
   


 
    // Start is called before the first frame update
    private void Awake()
    {
        _anim = GetComponent<Animator>();
        _au = GetComponent<AudioSource>();
        _comtra = GetComponent<Transform>();
        _combox = GetComponent<BoxCollider2D>();
    }
    private void Update()
    {
        _comtra.position = new Vector2(transform.position.x, transform.position.y - 1*Time.deltaTime);
    }

    private void FixedUpdate()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bala")
        {
            _au.Play();
            _anim.SetBool ("muerte",false);
            _combox.isTrigger = true ;
        }
        if (collision.gameObject.tag == "pared")
        {
            _au.Play();
            _anim.SetBool("muerte", false);
            _combox.isTrigger = true;
        }
    }
    public void fin()
    {
        Destroy(this.gameObject);
    }
    
}
