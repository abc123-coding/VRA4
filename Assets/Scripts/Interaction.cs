using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    private Animator anim;
    //private Camera main_cam;
    //private GameObject player;

    private const string animBoolName = "isOpen_Obj_";

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
        //main_cam = Camera.main;

        anim = GetComponent<Animator>();
        anim.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale != 0.0f & Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit = new RaycastHit();
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
            if (Physics.Raycast(ray, out hit, 10))
            {
                MoveableObject moveableObject = hit.collider.gameObject.GetComponent<MoveableObject>();
                if (moveableObject != null)
                {
                    string animBoolNameNum = animBoolName + moveableObject.objectNumber.ToString();

                    bool isOpen = anim.GetBool(animBoolNameNum);

                    if(Input.GetButtonDown("Fire1"))
                    {
                        anim.enabled = true;
                        anim.SetBool(animBoolNameNum, !isOpen);
                    }
                }
            }
        }
    }
}
