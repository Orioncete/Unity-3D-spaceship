using UnityEngine;
using System.Collections;

public class letreroCongrats : MonoBehaviour {
    public float letterSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.right * letterSpeed * Time.deltaTime, Space.World);
    }
}