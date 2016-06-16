using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LlegadaAMeta : MonoBehaviour {
    public AudioClip musiquilla;
    public GameObject posCongrats;
    public GameObject posBien;
    public GameObject superadoIngles;
    public GameObject superadoEsp;
    private float delayLlegada;
    private float i;

    private bool finish = false;

    
        

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(Vector3.up * 15 * Time.deltaTime);
        if (this.finish && delayLlegada <= Time.time)
        {
            SceneManager.LoadScene("EsquivandoCubos");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "jugador")
        {
            this.delayLlegada = Time.time + 5.0f;
            if (this.finish == false)
            {
                Instantiate(this.superadoIngles, this.posCongrats.transform.position, this.posCongrats.transform.rotation);
                Instantiate(this.superadoEsp, this.posBien.transform.position, this.posBien.transform.rotation);
            }
            AudioSource.PlayClipAtPoint(this.musiquilla, Camera.main.transform.position);
            this.finish = true;
            Destroy(other.gameObject);
        }
    }
}
