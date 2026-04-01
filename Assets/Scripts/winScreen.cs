using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class winScreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
     void Start()
    {
        StartCoroutine(sixamLoad());
    }

    // Update is called once per frame
    IEnumerator sixamLoad()
    {
        yield return new WaitForSeconds(360f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
