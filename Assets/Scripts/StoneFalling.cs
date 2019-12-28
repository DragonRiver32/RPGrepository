using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneFalling : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject, 0.1f);
        }
    }
}
