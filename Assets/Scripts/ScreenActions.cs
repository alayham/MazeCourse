using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Question
{
    string qText = "";
    string qAnswer = "";
    string uAnswer = "";

    public Question (string QText, string QAnswer)
    {
        qText = QText;
        qAnswer = QAnswer;
    }
    public string QText
    {
        get { return qText; }
    }
    public string UAnswer
    {
        get { return uAnswer; }
        set { uAnswer = value; }
    }
    public bool IsCorrect()
    {
        return uAnswer == qAnswer;
    }
}

public class ScreenActions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
