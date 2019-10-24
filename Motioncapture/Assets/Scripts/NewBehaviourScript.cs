using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    Animator myAnimator;
	// Use this for initialization
	void Start () {
        myAnimator = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            myAnimator.SetTrigger("跳舞觸發氣");
        }
        if (Input.GetKey(KeyCode.R))
        {
            myAnimator.SetBool("跑步開關", true);
        }
        else
        {
            myAnimator.SetBool("跑步開關", false);
        }
    }

}
