using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CrihManager : MonoBehaviour
{
    public GameObject crihCam6;
    public GameObject crihCam5;
    public GameObject crihCam4;
    public GameObject crihCam3;
    public GameObject crihCam2;
    public GameObject crihCam1;

    void Start()
    {
    StartCoroutine(Animatronics());
    crihCam6.SetActive(true);
    crihCam5.SetActive(false);
    crihCam4.SetActive(false);
    crihCam3.SetActive(false);
    crihCam2.SetActive(false);
    crihCam1.SetActive(false);

    }

    IEnumerator Animatronics()
    {
    crihCam6.SetActive(true);
    yield return new WaitForSeconds(90f);
    crihCam5.SetActive(true);
    crihCam6.SetActive(false);
    yield return new WaitForSeconds(30f);
    crihCam6.SetActive(true);
    crihCam5.SetActive(false);
    yield return new WaitForSeconds(60f);
    crihCam4.SetActive(true);
    crihCam6.SetActive(false);
    yield return new WaitForSeconds(20f);
    crihCam3.SetActive(true);
    crihCam4.SetActive(false);
    yield return new WaitForSeconds(35f);
    crihCam2.SetActive(true);
    crihCam3.SetActive(false);
    yield return new WaitForSeconds(65f);
    crihCam3.SetActive(true);
    crihCam2.SetActive(false);
    yield return new WaitForSeconds(40f);
    crihCam1.SetActive(true);
    crihCam3.SetActive(false);
    StartCoroutine(Animatronics());    
    }
}
