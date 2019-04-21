using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class choque : MonoBehaviour {
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Finish")
        {
            scoreCounter.contador += 10;
            AudioSource source = GetComponent<AudioSource>();
            source.Play();
            Destroy(col.gameObject);
        }
    }
}
