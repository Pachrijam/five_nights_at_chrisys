using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class crihs : MonoBehaviour
{
    
    public GameObject crih1;
    public GameObject crih2;

    void Start()
    {
    StartCoroutine(Anims());
    crih1.SetActive(true);
    crih2.SetActive(false);   
    }

    IEnumerator Anims()
    {
        crih1.SetActive(true);
        yield return new WaitForSeconds(2f);
        crih2.SetActive(true);
        crih1.SetActive(false);
        yield return new WaitForSeconds(0.01f);
        crih2.SetActive(true);
        crih1.SetActive(false);
        yield return new WaitForSeconds(0.02f);
        crih2.SetActive(true);
        crih1.SetActive(false);
        yield return new WaitForSeconds(1f);
        crih2.SetActive(true);
        crih1.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        crih2.SetActive(true);
        crih1.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        StartCoroutine(Anims());
    }
}
