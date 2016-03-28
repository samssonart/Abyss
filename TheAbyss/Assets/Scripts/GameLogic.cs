using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour {

    private GameObject selectedObject;
    public float distance = 1f;

	// Use this for initialization
	void Start ()
    {
        selectedObject = null;
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (selectedObject != null)
        {
            Vector3 newPosition = Camera.main.transform.position + Camera.main.GetComponent<StereoController>().Head.Gaze.direction.normalized * distance;
            selectedObject.transform.position = newPosition;

        }
	
	}

    public void SetSelectedObject(GameObject go)
    {
        selectedObject = go;

    }
}
