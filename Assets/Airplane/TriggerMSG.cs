using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TriggerMSG : MonoBehaviour


{
    public Text messageText;
    public string displayMessage = "You found Anne!";
    public float displayDuration = 2f;

    private bool displayActive = false;
    private float displayTimer;

    private void Start()
    {
        // Ensure the text is initially hidden
        messageText.enabled = false;
    }

    private void Update()
    {
        if (displayActive)
        {
            // Display the text message
            messageText.text = displayMessage;
            messageText.enabled = true;

            // Start the timer
            displayTimer += Time.deltaTime;

            // Check if the timer has exceeded the display duration
            if (displayTimer >= displayDuration)
            {
                // Hide the text
                messageText.enabled = false;

                // Reset the timer and flag
                displayTimer = 0f;
                displayActive = false;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the player has entered the collider
        if (other.CompareTag("Player"))
        {
            displayActive = true;
        }
    }
}

