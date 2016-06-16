using UnityEngine;
using System.Collections;

public class CuboHoriz : MonoBehaviour {
    public float movSpeed;
    private float giroRan;

	// Use this for initialization
	void Start () {

       
                
	}
	
	// Update is called once per frame
	void Update () {
        this.giroRan = Random.Range(0.8f, 1.5f);
        this.transform.Translate(Vector3.left * this.movSpeed * Time.deltaTime, Space.World);
        this.transform.Rotate(Vector3.right * 30 * giroRan * Time.deltaTime, Space.World);
        this.transform.Rotate(Vector3.up * 15 * Time.deltaTime, Space.World);
        this.transform.Rotate(Vector3.forward * 15 * Time.deltaTime, Space.World);
    }
}
