using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class menuchange : MonoBehaviour {
	//public levelchange2 yourButton;


	void Start () {
		//Button btn = yourButton.GetComponent<Button>();
		//btn.onClick.AddListener(TaskOnClick);
	}

	public void TaskOnClick(){
        SceneManager.LoadScene(1);
        Debug.Log("Triggered");  
	}
}
