using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cameras : MonoBehaviour
{
    public Camera office;
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    public Camera cam4;
    public Camera cam5;
    public Camera cam6;

    public GameObject camUp;
    public GameObject camDown;


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        office.gameObject.SetActive(true);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        cam4.gameObject.SetActive(false);
        cam5.gameObject.SetActive(false);
        cam6.gameObject.SetActive(false);

        camUp.SetActive(true);
        camDown.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CamUp()
    {
        office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(true);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        cam4.gameObject.SetActive(false);
        cam5.gameObject.SetActive(false);
        cam6.gameObject.SetActive(false);
        camUp.SetActive(false);
        camDown.SetActive(true);
    }

    public void CamDown()
    {
        office.gameObject.SetActive(true);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        cam4.gameObject.SetActive(false);
        cam5.gameObject.SetActive(false);
        cam6.gameObject.SetActive(false);
        camUp.SetActive(true);
        camDown.SetActive(false);
    }

    public void Cam1()
    {
        office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(true);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        cam4.gameObject.SetActive(false);
        cam5.gameObject.SetActive(false);
        cam6.gameObject.SetActive(false);
    }
    public void Cam2()
    {
        office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(true);
        cam3.gameObject.SetActive(false);
        cam4.gameObject.SetActive(false);
        cam5.gameObject.SetActive(false);
        cam6.gameObject.SetActive(false);
    }
    public void Cam3()
    {
        office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(true);
        cam4.gameObject.SetActive(false);
        cam5.gameObject.SetActive(false);
        cam6.gameObject.SetActive(false);
    }
    public void Cam4()
    {
        office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        cam4.gameObject.SetActive(true);
        cam5.gameObject.SetActive(false);
        cam6.gameObject.SetActive(false);
    }
    public void Cam5()
    {
        office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        cam4.gameObject.SetActive(false);
        cam5.gameObject.SetActive(true);
        cam6.gameObject.SetActive(false);
    }
    public void Cam6()
    {
        office.gameObject.SetActive(false);
        cam1.gameObject.SetActive(false);
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        cam4.gameObject.SetActive(false);
        cam5.gameObject.SetActive(false);
        cam6.gameObject.SetActive(true);
    }
}
