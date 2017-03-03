using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimations : MonoBehaviour {

    public int QuestionID = -1;

    Animator animator;
    ScreenActions panel;

    private void OnTriggerEnter(Collider other)
    {
        if (animator.GetBool("IsUnlocked"))
            animator.SetTrigger("Open");
        else
            panel.Door = this;
    }

    private void OnTriggerExit(Collider other)
    {
        if (animator.GetBool("IsUnlocked"))
            animator.SetTrigger("Close");
        else
            panel.Door = null;
    }

    // Use this for initialization
    void Start () {
        animator = GetComponentInChildren<Animator>();
        panel = GameObject.Find("Canvas").GetComponent<ScreenActions>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
