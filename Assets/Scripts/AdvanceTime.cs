using System;
using System.Collections;
using TMPro;
using UnityEngine;


public class AdvanceTime : MonoBehaviour
{
   [SerializeField] private int startingTime;
    [SerializeField] private float timeUntilHourChange;
    [SerializeField] private TMP_Text timeText;
    [SerializeField] private int timeLimit;

    [NonSerialized] public int timeHours;
    
    private void Start()
    {
        timeHours = startingTime;
        StartCoroutine(advanceHourOverTime());
    }

    private void Update()
    {
        timeText.text = timeHours + ":00 AM";
    }

    private IEnumerator advanceHourOverTime()
    {
        yield return new WaitForSeconds(timeUntilHourChange);

        if (timeHours == 12)
            timeHours = 1;
        else
            timeHours++;
        
        if (timeHours < timeLimit)
            StartCoroutine(advanceHourOverTime());
    }

}
