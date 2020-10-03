using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fivehundredScoreScript : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Stage2GameManager.scorebyItem += 500;
            Destroy(this.gameObject);
        }
    }
}
