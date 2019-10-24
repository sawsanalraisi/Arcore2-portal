using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScripts : MonoBehaviour
{


    Animator m_Animator;
    public GameObject border;

    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (OVRInput.GetUp(OVRInput.Button.One) || Input.GetKey(KeyCode.A))
        {
            m_Animator.SetBool("IsPlay", false);
        }

        if (OVRInput.GetUp(OVRInput.Button.Two) || Input.GetKey(KeyCode.B))
        {
            m_Animator.SetBool("IsPlay", true);
        }


    }
}
