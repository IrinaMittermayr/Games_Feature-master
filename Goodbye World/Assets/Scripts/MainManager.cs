using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour {
    Transform positionFixer;

    public GameObject currentHeldObj = null;
    public float reach = 2;
    public LayerMask ignore;

    void Start () {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        positionFixer = new GameObject().transform;
    }
	
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            if (currentHeldObj == null)
            {
                Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit, 5))
                {

                    if (hit.transform.tag == "Pickupable")
                    {
                        PickupObject(hit.transform.gameObject);
                    }
                }
            }
            else
            {
                PickupObject(null);
            }
        }
    }

    void PickupObject(GameObject newObj)
    {
        if (newObj != null)
        {
            newObj.GetComponent<Rigidbody>().isKinematic = true;
            currentHeldObj = newObj;
        }
        else
        {
            currentHeldObj.GetComponent<Rigidbody>().isKinematic = false;
            currentHeldObj = null;
        }
    }

    void FixedUpdate()
    {
        if (currentHeldObj != null)
        {
            RaycastHit hit;
            if (Physics.SphereCast(Camera.main.transform.position, .4f, Camera.main.transform.forward, out hit, reach, ignore))
            {
                float f = Vector3.Distance(Camera.main.transform.position, hit.point);
                positionFixer.position = Camera.main.transform.position + (Camera.main.transform.forward * f) - Camera.main.transform.forward * .2f;
            }
            else
            {
                positionFixer.position = Camera.main.transform.position + (Camera.main.transform.forward * reach);
            }

            currentHeldObj.transform.position = Vector3.Lerp(currentHeldObj.transform.position, positionFixer.position, Time.deltaTime * 20);
            //Quaternion newRot = Quaternion.Euler(currentHeldObj.transform.rotation.eulerAngles.x, Camera.main.transform.rotation.eulerAngles.y, currentHeldObj.transform.rotation.eulerAngles.z);
            Quaternion newRot = Quaternion.Euler(Camera.main.transform.rotation.eulerAngles.x, Camera.main.transform.rotation.eulerAngles.y, Camera.main.transform.rotation.eulerAngles.z);
            currentHeldObj.transform.rotation = Quaternion.Lerp(currentHeldObj.transform.rotation, newRot, Time.deltaTime * 10);
        }
    }
}