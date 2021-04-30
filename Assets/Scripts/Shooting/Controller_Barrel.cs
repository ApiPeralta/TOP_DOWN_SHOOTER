using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Barrel : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Restart._Restart.OnRestart += Reset;
    }

    private void Reset()
    {
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
        }
    }
    private void OnDisable()
    {
        Restart._Restart.OnRestart -= Reset;
    }
}

