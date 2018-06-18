using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {
    public GameObject Spawnable;
	// Use this for initialization
	void Start () {
        Instantiate(Spawnable);
        Destroy(this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
