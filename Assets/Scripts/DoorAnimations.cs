using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimations : MonoBehaviour {

    Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("Open");
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetTrigger("Close");
    }

    // Use this for initialization
    void Start () {
        animator = GetComponentInChildren<Animator>();
        animator.SetBool("IsUnlocked", true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
