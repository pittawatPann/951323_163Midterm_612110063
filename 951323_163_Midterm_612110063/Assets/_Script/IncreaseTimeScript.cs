using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseTimeScript : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Stage2GameManager._Time2 += 3;
            Destroy(this.gameObject);
        }
    }
}
