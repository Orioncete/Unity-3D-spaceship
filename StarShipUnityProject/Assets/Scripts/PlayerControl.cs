using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
    public float horizSpeed;
    public float vertSpeed;
    
	// Use this for initialization
	void Start () {        

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Horizontal") != 0.0f)
        {
            this.transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * horizSpeed * Time.deltaTime);
        }
        if (Input.GetAxis("Vertical") != 0.0f)
        {
            this.transform.Translate(Vector3.up * Input.GetAxis("Vertical") * vertSpeed * Time.deltaTime);
        }
    }
}
