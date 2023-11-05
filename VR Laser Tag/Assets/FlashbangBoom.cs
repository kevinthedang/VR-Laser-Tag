using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FlashbangBoom : MonoBehaviour
{
    public GameObject flashObj;
    public Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(BoomHandler);
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //
    }

    void BoomHandler(ActivateEventArgs args)
    {
        Invoke("Boom", 5);
    }
    
    void Boom()
    {
        if (blinded())
            Debug.Log("Blind");
        else
            Debug.Log("Clear");
        Destroy(gameObject, (float)0.1);
        GameObject flash = Instantiate(flashObj, transform.position, Quaternion.identity);
        Destroy(flash, 2);
    }

    bool blinded()
    {
        var planes = GeometryUtility.CalculateFrustumPlanes(mainCamera);
        var point = transform.position;

        foreach (var plane in planes)
            return plane.GetDistanceToPoint(point) > 0;
        
        return false;
    }
}
