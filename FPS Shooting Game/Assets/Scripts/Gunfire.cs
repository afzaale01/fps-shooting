using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunfire : MonoBehaviour
{
    public GameObject Flash;
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
        if (GlobalAmmo.LoadedAmmo >= 1)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                AudioSource gunFire = GetComponent<AudioSource>();
                gunFire.Play();
                Flash.SetActive(true);
                StartCoroutine(MuzzleOff());
                //GetComponent<Animator>().Play("gunShoot");                
                GetComponent<Animator>().SetTrigger("fire") ;                
                GlobalAmmo.LoadedAmmo -= 1;


                up.GetComponent<Animator>().Play("Upper");
                down.GetComponent<Animator>().Play("Down");
                left.GetComponent<Animator>().Play("Left");
                right.GetComponent<Animator>().Play("Right");

            }
        }
    }


    

    public IEnumerator MuzzleOff()
    {

        yield return new WaitForSeconds(0.15f);
        Flash.SetActive(false);
    }



}
