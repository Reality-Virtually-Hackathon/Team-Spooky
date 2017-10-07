﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject player;
    public GameObject forwardObject;
    public float XSensitivity = 2f;
    public float YSensitivity = 2f;
    public bool clampVerticalRotation = true;
    public float MinimumX = -90F;
    public float MaximumX = 90F;
    public bool smooth;
    public float smoothTime = 5f;
    public bool lockCursor = true;


    private Quaternion m_CharacterTargetRot;
    private Quaternion m_CameraTargetRot;
    private bool m_cursorIsLocked = true;

    public void Start()
    {
        m_CharacterTargetRot = transform.localRotation;
        m_CameraTargetRot = transform.localRotation;
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0)) { Interact(); }
        if (Input.GetKey(KeyCode.Space) )
        { player.transform.position = Vector3.MoveTowards(player.transform.position, forwardObject.transform.position, 4 * Time.deltaTime); }

            if (Input.GetKey(KeyCode.Tab) || lockCursor == false)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            LookRotation(player.transform, this.transform);
        }


    }
    public void Interact() {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit, 5.0f) && hit.transform.tag == "Interactable")
        {
            hit.transform.gameObject.SendMessage("Interact", this.gameObject);

        }
    }
    public void LookRotation(Transform character, Transform camera)
    {
        float yRot = Input.GetAxis("Mouse X") * XSensitivity;
        float xRot = Input.GetAxis("Mouse Y") * YSensitivity;

        m_CharacterTargetRot *= Quaternion.Euler(0f, yRot, 0f);
        m_CameraTargetRot *= Quaternion.Euler(-xRot, 0f, 0f);

        if (clampVerticalRotation)
            m_CameraTargetRot = ClampRotationAroundXAxis(m_CameraTargetRot);

        if (smooth)
        {
            character.localRotation = Quaternion.Slerp(character.localRotation, m_CharacterTargetRot,
                smoothTime * Time.deltaTime);
            camera.localRotation = Quaternion.Slerp(camera.localRotation, m_CameraTargetRot,
                smoothTime * Time.deltaTime);
        }
        else
        {
            character.localRotation = m_CharacterTargetRot;
            camera.localRotation = m_CameraTargetRot;
        }
  
        
    }

   
    

    Quaternion ClampRotationAroundXAxis(Quaternion q)
    {
        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1.0f;

        float angleX = 2.0f * Mathf.Rad2Deg * Mathf.Atan(q.x);

        angleX = Mathf.Clamp(angleX, MinimumX, MaximumX);

        q.x = Mathf.Tan(0.5f * Mathf.Deg2Rad * angleX);

        return q;
    }
}
