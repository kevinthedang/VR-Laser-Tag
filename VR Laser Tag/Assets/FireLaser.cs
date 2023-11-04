using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireLaser : MonoBehaviour
{
    public GameObject laserObj;
    public Transform spawn;
    public float speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(Fire);
    }

    // Update is called once per frame
    void Update()
    {
        //
    }

    void Fire(ActivateEventArgs args)
    {
        GameObject laser = Instantiate(laserObj);
        laser.transform.eulerAngles = new Vector3(spawn.position.x, spawn.position.y + 90, spawn.position.z + 90);
        laser.transform.position = spawn.position;
        laser.GetComponent<Rigidbody>().velocity = spawn.forward * speed;
        //Destroy(laser, 5);
    }
}
