using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Triggering the Animation using the box collider
// Stand and walk animation for the rugged guy sitting near the parking ticket machine.
public class Rugged : MonoBehaviour
{
    Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = this.GetComponent<Animator>();
;    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("On Rugged man");
        if(m_Animator)
        {
            m_Animator.SetBool("isNear", true);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
