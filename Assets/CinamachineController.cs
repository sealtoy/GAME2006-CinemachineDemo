using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinamachineController : MonoBehaviour
{
    private Animator anim;
    private bool isGroupCamera = true;

    public GameObject PlayerFollow;
    public GameObject BladeFollow;
    public GameObject PlatformFollow;


    private void Awake()
    {
        anim = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isGroupCamera = !isGroupCamera;
            anim.SetBool("isGroupCamera", isGroupCamera);
        }
    }
}
