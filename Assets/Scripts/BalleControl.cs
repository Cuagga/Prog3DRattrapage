using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BalleControl : MonoBehaviour
{
    // Start is called before the first frame update
    public ControlText txt;

    bool plan;
    Rigidbody rigid;
    Transform orient;

    void Start()
    {
        plan = true;
        rigid = GetComponent<Rigidbody>();
        orient = GetComponent<Transform>();
        rigid.AddForce(orient.forward/10, ForceMode.Impulse);
        txt.forward = orient.forward;
        
        Destroy(this.gameObject, 1);
    }

    void OnTriggerEnter(Collider coll)
    {
        plan = false;
        Destroy(this.gameObject);
    }
    // Update is called once per frame

    void OnDestroy()
	{
        txt.shot++;
		if (plan)
		{
            txt.fails++;
		}
		else
		{
            txt.kills++;
		}
    }

}