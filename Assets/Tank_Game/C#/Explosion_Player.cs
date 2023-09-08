using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion_Player : MonoBehaviour
{
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.Play("Player_Explosion");
        Destroy(gameObject, 0.5f);
    }

}
