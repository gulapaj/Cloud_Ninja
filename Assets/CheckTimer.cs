using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckTimer : MonoBehaviour
{
    private Text displayTxt;
    public float time = 0.0f;
    private bool check = true;


    // Start is called before the first frame update
    void Start()
    {
        displayTxt = GetComponentInChildren<Text>(true);
    }

    // Update is called once per frame
    void Update()
    {
        //Shows and add real time in the screen
        if (check)
        {
            time += Time.deltaTime;
            displayTxt.text = $"Time: {time:F2}";
        }
    }
}
