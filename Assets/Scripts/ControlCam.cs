using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ControlCam : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ballePrefab;
    GameObject balle;
    Transform cam;

    bool run = false;
    float rotSpeed = 90;
    float speed = 5;

    Vector3 mouse;

    void Start()
    {
        cam = GetComponent<Transform>();
        mouse = Input.mousePosition;
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            run = !run;
        }

		if (run)
		{
            speed = 15;
		}
		else { 
            speed = 5;
        }
        if (Input.GetKey("left"))
        {
            cam.eulerAngles += new Vector3(0, - rotSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey("right"))
        {
            cam.eulerAngles += new Vector3(0, rotSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey("up"))
        {
            cam.eulerAngles += new Vector3(-rotSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("down"))
        {
            cam.eulerAngles += new Vector3(rotSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("z"))
		{
            cam.Translate(new Vector3(cam.forward.x, 0, cam.forward.z) * speed * Time.deltaTime);
		}
        if (Input.GetKey("s"))
        {
            cam.Translate(new Vector3(-cam.forward.x, 0, -cam.forward.z) * speed * Time.deltaTime);
        }
        if (Input.GetKey("q"))
        {
            cam.Translate(new Vector3(-cam.right.x, 0, -cam.right.z) * speed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            cam.Translate(new Vector3(cam.right.x, 0, cam.right.z) * speed * Time.deltaTime);
        }
        cam.position = new Vector3(cam.position.x, 2, cam.position.z);
        if (Input.GetMouseButtonDown(0))
		{
            Instantiate(ballePrefab, new Vector3(cam.position.x + 1, 2, cam.position.z), cam.rotation);
		}
    }
}
