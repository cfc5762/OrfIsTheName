using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Warp : MonoBehaviour {
    public string SceneName;
    public bool warp;
	// Use this for initialization
	void Start () {
        warp = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (warp)
        {
            warp = false;
            try
            {
                SceneManager.LoadScene(SceneName);
            }
            catch (System.Exception)
            {

                print("Null Scene");
            }
            
        }
	}
}
