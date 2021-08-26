using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRRig : MonoBehaviour
{
    public Animator animator;

    public VRMap head;
    public VRMap LHand;
    public VRMap RHand;

    public Transform headConstraint;
    public Vector3 headBodyOffset;
    public Vector3 feetOffset;
    public float turnSmoothness;
    public float speedOffset;


    // Start is called before the first frame update
    void Start()
    {
        headBodyOffset = transform.position - headConstraint.position;
    }



    private void Update()
    {
        //if(InputHandler.instance.W == InputKey.Down)
        //{
        //    animator.speed += 0.01f;
        //}

        //if (InputHandler.instance.S == InputKey.Down)
        //{
        //    animator.speed -= 0.01f;
        //}

        // transform.position += transform.forward * (animator.speed * Time.deltaTime);
        //legAnimation.speed = leftJoystick.axis.y;
    }


    void FixedUpdate()
    {
        transform.position = headConstraint.position + headBodyOffset;
        transform.forward = Vector3.Lerp(transform.forward, Vector3.ProjectOnPlane(headConstraint.up, Vector3.up).normalized, turnSmoothness);

        head.Map();
        LHand.Map();
        RHand.Map();
    }
}