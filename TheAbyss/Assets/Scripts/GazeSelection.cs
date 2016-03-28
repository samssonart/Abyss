using UnityEngine;
using System.Collections;

public class GazeSelection : MonoBehaviour {

    private Vector3 startingPosition;
    public Material mat;
    public Color basecolor;
    public GameLogic gameLogic;


    // Use this for initialization
    void Start () {

        startingPosition = transform.localPosition;
        SetGazedAt(false);

    }

    public void SetGazedAt(bool gazedAt)
    {
        if (gazedAt) { mat.SetColor("_EmissionColor", basecolor); gameLogic.SetSelectedObject(gameObject); }
        else { mat.SetColor("_EmissionColor", Color.black); gameLogic.SetSelectedObject(null); }
        }

    // Update is called once per frame
    void Update () {
	
	}
}
