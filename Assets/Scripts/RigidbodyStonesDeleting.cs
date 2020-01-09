using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyStonesDeleting : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject, 10f);
        }
    }
}
