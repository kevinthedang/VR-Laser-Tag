using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserHit : MonoBehaviour
{
    public GameObject blast;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject spawnBlast = Instantiate(blast);
        spawnBlast.transform.position = transform.position;
        Destroy(spawnBlast);
        Destroy(gameObject);
    }
}
