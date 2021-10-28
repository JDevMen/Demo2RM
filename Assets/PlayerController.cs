using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PlayerController : MonoBehaviour
{

    public SteamVR_Action_Vector2 input;
    public float speed = 1;
    private CharacterController characterController = null;
    private Transform cameraRig = null;
    private Transform head = null;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }


    // Start is called before the first frame update
    void Start()
    {
        cameraRig = SteamVR_Render.Top().origin;
        head = SteamVR_Render.Top().head;
    }

    // Update is called once per frame
    void Update()
    {
        HandleHead();
        CalculateMovement();
        HandleHeight();
    }

    private void HandleHead()
    {
        Vector3 oldPosition = cameraRig.position;
        Quaternion oldRotation = cameraRig.rotation;
        transform.eulerAngles = new Vector3(0.0f, head.rotation.eulerAngles.y, 0.0f);

        cameraRig.position = oldPosition;
        cameraRig.rotation = oldRotation;
    }

    private void CalculateMovement()
    {

    }

    private void HandleHeight()
    {

    }
}
