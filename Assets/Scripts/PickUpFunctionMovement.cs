using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using HTC.UnityPlugin.Vive;

public class PickUpFunctionMovement : MonoBehaviour {

    public Transform RightController;
    public Transform LeftController;

	// Use this for initialization
	void Start () {
        if (RightController != null)
        {
            var controller = GameObject.Find("RightHand");
            if (controller != null)
            {
                RightController = controller.transform;

            }
            else
            {
                Debug.LogError("No Right Controller found in the scene.");
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (ViveInput.GetPressDownEx(HandRole.RightHand, ControllerButton.Trigger))
        {
            var ray = new Ray();
            ray.origin = RightController.position;

        }
    }
}
