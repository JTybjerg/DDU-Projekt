using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public Text Scorevalue;
    public float scorevalue = 0f;
    public float scoreincreasepersecond = 3f;

    // Update is called once per frame
    void Update()
    {
        Scorevalue.text = ((int)scorevalue).ToString();
        scorevalue += scoreincreasepersecond * Time.fixedDeltaTime;
        scoreincreasepersecond += 0.001f * Time.fixedDeltaTime;

        
    }
}
