using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour {

    // Use this for initialization
    public Animation animator;
	void Start () {
        animator = GetComponent<Animation>();	
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (!animator.isPlaying) animator.Play("Take 001");
	}
}
