﻿using UnityEngine;
using System.Collections;

public class InstanciadorVert : MonoBehaviour {
    public float tiempoDeCiclo;
    public GameObject posicion;
    public GameObject enemy;

    private float posLateral;
    private float posVertical;

    private float lastSpawnTime;

    // Use this for initialization
    void Start () {
        this.lastSpawnTime = Time.time;
        this.posVertical = 4.5f;

    }
	
	// Update is called once per frame
	void Update () {
        this.posLateral = Random.Range(-9.9f, 9.9f);
        this.transform.position = new Vector3(this.posLateral, this.posVertical, -0.0f);
        if (Time.time - this.lastSpawnTime >= this.tiempoDeCiclo)
        {
            Instantiate(this.enemy, this.posicion.transform.position, this.posicion.transform.rotation);
            this.lastSpawnTime = Time.time;
        }

    }
}
