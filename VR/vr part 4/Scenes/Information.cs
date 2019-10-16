using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Information : MonoBehaviour
{

    public Text ShowInfo;

    public Animator animator;
  //  bool IsShowBorder;
    public GameObject SmartcityTxt;


    public void Start()
    {
       // IsShowBorder = false;
        SmartcityTxt.SetActive(false);
        animator = GetComponent<Animator>();
        animator.enabled = true;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "BuildInfoTag")
        {
            animator.SetTrigger("IsShowBorder");
         //   IsShowBorder = true;
            SmartcityTxt.SetActive(true);
            ShowInfo.text = "BuildInfoTag";
        }

    }

    public void BorderFun()
    {
        animator.enabled = true;
    }

}
