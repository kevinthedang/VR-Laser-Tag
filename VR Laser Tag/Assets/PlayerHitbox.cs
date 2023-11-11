using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitbox : MonoBehaviour
{
    public Camera mainCamera;
    public int hp;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Player";
        hp = 100;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = mainCamera.transform.position;
        transform.rotation = mainCamera.transform.rotation;
    }

    void takeDamage()
    {
        hp -= 10;

        if (hp <= 0)
            Destroy(gameObject);
    }
}
