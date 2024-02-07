using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransitionController : MonoBehaviour
{
    public CinemachineStateDrivenController controller;



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            controller.TransitionToGroupCamera();
        }

        else if (other.CompareTag("Blade"))
        {
            controller.TransitionToGroupCamera();
        }

        else if (other.CompareTag("Platform"))
        {
            controller.TransitionToGroupCamera();
        }

    }

}
