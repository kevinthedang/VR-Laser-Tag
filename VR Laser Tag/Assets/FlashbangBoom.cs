using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FlashbangBoom : MonoBehaviour
{
    public GameObject flashObj;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(BoomHandler);
    }

    // Update is called once per frame
    void Update()
    {
        //
    }

    void BoomHandler(ActivateEventArgs args)
    {
        Invoke("Boom", 2);
    }
    
    void Boom()
    {
        Destroy(gameObject, (float)0.1);
        GameObject flash = Instantiate(flashObj, transform.position, Quaternion.identity);
        Destroy(flash, (float)0.75);
    }
}
