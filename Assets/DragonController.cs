using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonController : MonoBehaviour
{
    public float speed;
    public FixedJoystick joystick;
    private Rigidbody rb;
    public Animator animator;
    private void OnEnable()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        joystick = FindObjectOfType<FixedJoystick>();
    }
    private void FixedUpdate()
    {
        float xval = joystick.Horizontal;
        float yval = joystick.Vertical;

        Vector3 movement = new Vector3(xval, 0, yval);
        rb.velocity = movement * speed;
        if (xval != 0 && yval != 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(xval, yval) * Mathf.Rad2Deg, transform.eulerAngles.z);
        }
        if (Input.GetButton("Fire1"))
        {
            animator.SetBool("fly", true);
            rb.AddForce(0, 15, 0);
        }
    }
}
