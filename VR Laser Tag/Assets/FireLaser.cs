using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.XRGrabInteractable;
using UnityEngine.XR.Interaction.Toolkit.ActivateEventArgs;

public class FireLaser : MonoBehaviour
{
    public GameObject laser;
    public Transform spawn;
    public float speed = 20.0;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.addListener(Fire);
    }

    // Update is called once per frame
    void Update()
    {
        //
    }

    void Fire(ActivateEventArgs arg)
    {
        GameObject laser = Instantiate(laserObj);
        laser.transform.position = spawn.position;
        laser.GetComponent<RigidBody>().velocity = spawn.forward * speed;
        //Destroy(laser, 5);
    }
}
