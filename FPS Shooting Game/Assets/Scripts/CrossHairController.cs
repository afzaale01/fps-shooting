using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossHairController : MonoBehaviour
{
    public GameObject up;
    public GameObject down;
    public GameObject left;
    public GameObject right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            up.GetComponent<Animator>().enabled=true;
            down.GetComponent<Animator>().enabled=true;
            left.GetComponent<Animator>().enabled=true;
            right.GetComponent<Animator>().enabled=true;
            //StartCoroutine(ResetDelay());
        }
    }


    IEnumerator ResetDelay()
    {
        yield return new WaitForSeconds(0.1f);
        up.GetComponent<Animator>().enabled = false;
        down.GetComponent<Animator>().enabled = false;
        left.GetComponent<Animator>().enabled = false;
        right.GetComponent<Animator>().enabled = false;
    }
}
