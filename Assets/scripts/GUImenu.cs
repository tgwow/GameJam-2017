using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUImenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame()
    {
#pragma warning disable CS0618 // O tipo ou membro é obsoleto
        Application.LoadLevel("introdution");
#pragma warning restore CS0618 // O tipo ou membro é obsoleto
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
