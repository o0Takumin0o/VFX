using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magicBullet : MonoBehaviour
{
    public GameObject canonball;
    public float shootForce = 0f;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            GameObject projectile = (GameObject)Instantiate
                (canonball, transform.position, transform.rotation);
            projectile.GetComponent<Rigidbody>().AddForce(projectile.transform.forward * shootForce);
        }
    }
}
