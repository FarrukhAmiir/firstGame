using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragandDrop : MonoBehaviour {

    public GameObject DraggedObject;
    public GameObject DroppingObject;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Drag()
    {
        DraggedObject.transform.position = Input.mousePosition;
       
    }

    public void Drop()
    {

        float distance = Vector3.Distance(DraggedObject.transform.position, DroppingObject.transform.position);
        if (distance < 70f)
        {
            DraggedObject.transform.position = DroppingObject.transform.position;
        }
    }
}
