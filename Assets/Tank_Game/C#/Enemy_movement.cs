using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_movement : MonoBehaviour
{
    public AudioSource Audio;
    void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.Translate(Vector3.left * 7 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Audio.Play();
    }
}
