using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdPersonController : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 6f;
    public float smoothing = 0.1f;
    float smoothVelocity;

    public Transform cam;
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z)*Mathf.Rad2Deg+ cam.eulerAngles.y;
            float Angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothVelocity, smoothing);
            transform.rotation = Quaternion.Euler(0f, Angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }

    }
}
