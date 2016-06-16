using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ColisionParedesfinales : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemigoHoriz")
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "jugador")
        {
            SceneManager.LoadScene("EsquivandoCubos");
        }
    }
}
