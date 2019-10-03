using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class backtomain : MonoBehaviour {

	void Start () {

	}

	public void TaskOnClick(){
        SceneManager.LoadScene(1);
	}
}