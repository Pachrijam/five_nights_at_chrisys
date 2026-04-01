using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(menuLoad());
    }

    // Update is called once per frame
    IEnumerator menuLoad()
    {
        yield return new WaitForSeconds(11f);
        SceneManager.LoadScene(0);
    }
}
