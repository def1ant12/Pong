using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehaviourScript : MonoBehaviour {
 
	// Use this for initialization
	public void OnButtonPressed(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
}
