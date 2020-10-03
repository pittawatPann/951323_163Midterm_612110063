using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExpanedPlayerControl : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < -1f)
        {
            Invoke("Dead", 2f);
            
        }
    }
    public void Dead()
    {
        SceneManager.UnloadScene("SceneGameplayStage1");
        SceneManager.LoadScene("SceneMainMenu");
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Slow"))
        {
            rb.mass += 1;
        }
    }



}
