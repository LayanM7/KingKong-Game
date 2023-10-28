using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{



    private Animator animator;
    private bool isAnimation1Active = true;
    private float animationTimer = 10f;


    private void Start()
    {
        // Get the Animator component attached to this GameObject.
        animator = GetComponent<Animator>();


    }

    private void Update()
    {
        // Update the timer.
        animationTimer -= Time.deltaTime;

        // Check if it's time to switch animations.
        if (animationTimer <= 0f)
        {
            animator.SetBool("isPlaying", true);
        }

        // Reset the timer.
        animationTimer = 10f;
        isAnimation1Active = !isAnimation1Active;
    }
}