using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScene : MonoBehaviour {
    public void GotoScene()
    {
        Debug.Log("my method was Called");
        SceneManager.LoadScene("Main");


    }
	
}
