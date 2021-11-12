using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    private Rigidbody rb;

  
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("PickUp")) {
            other.gameObject.SetActive(false);
            other.GetComponent<RecycleItem>().sortItem();
            Time.timeScale = 0;
            }
    }
}
