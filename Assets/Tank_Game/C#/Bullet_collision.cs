using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_collision : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.Play("Bullet_penetration");
        Destroy(gameObject, 0.2f);
        
    }
}
