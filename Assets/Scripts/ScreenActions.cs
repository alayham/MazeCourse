using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    GameObject panel;
    DoorAnimations door;

    Question[] questions = new Question[10];

    public Text text;
    public InputField inputfield;

    public DoorAnimations Door
    {
        get { return door; }
        set
        {
            door = value;
            if (canShow())
                show();
            else
                hide();
        }
    }

    bool canShow()
    {
        return door != null && door.QuestionID >= 0 && questions[door.QuestionID] != null;
    }
    // Use this for initialization

    void show()
    {
        if (canShow())
        {
            text.text = questions[door.QuestionID].QText;
            inputfield.text = questions[door.QuestionID].UAnswer;
            panel.SetActive(true);
            inputfield.ActivateInputField();
        }
    }

    void hide()
    {
        panel.SetActive(false);
    }

    public void CheckAnswer()
    {
        Question tmp = questions[door.QuestionID];
        Animator animator;
        tmp.UAnswer = inputfield.text;
        if (tmp.IsCorrect())
        {
            hide();
            animator = door.gameObject.GetComponentInChildren<Animator>();
            animator.SetBool("IsUnlocked", true);
            animator.SetTrigger("Open");
        }

    }

    void Start()
    {
        panel = transform.Find("Panel").gameObject;
        hide();

        questions[0] = new Question("Enter 1234", "1234");
        questions[1] = new Question("Enter 1254", "1254");
        questions[2] = new Question("Enter 1269", "1269");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
