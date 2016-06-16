using UnityEngine;
using System.Collections;

public class CuboVert : MonoBehaviour {
    public float movSpeed;
    private float giroRan;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.giroRan = Random.Range(0.8f, 1.5f);
        this.transform.Translate(Vector3.down * this.movSpeed * Time.deltaTime, Space.World);
        this.transform.Rotate(Vector3.right * 45 * giroRan * Time.deltaTime, Space.World);
        this.transform.Rotate(-Vector3.up * 30 * Time.deltaTime, Space.World);
        this.transform.Rotate(-Vector3.forward * 45 * Time.deltaTime, Space.World);
    }
}
