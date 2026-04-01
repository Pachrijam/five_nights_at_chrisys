using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class DeathManager : MonoBehaviour
{
    public bool enableDeathLoad = true;
    public float deathDelay = 350f;
    public float cancelWindowDuration = 10f;

    private Coroutine _deathCoroutine;
    private float _deathStartTime;

    void Start()
    {
        if (enableDeathLoad)
        {
        _deathCoroutine = StartCoroutine(DeathLoad());
        }
    }

    public bool TryCancelDeathLoad()
    {
        float elapsed = Time.time - _deathStartTime;

        if (elapsed <= cancelWindowDuration && _deathCoroutine != null)
        {
            StopCoroutine(_deathCoroutine);
            _deathCoroutine = null;
            return true;
        }
        else
        {
            return false;
        }
    }

    IEnumerator DeathLoad()
    {
    yield return new WaitForSeconds(deathDelay);
    _deathStartTime = Time.time;
    yield return new WaitForSeconds(cancelWindowDuration);
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

}
