using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;


public class SceneButton : MonoBehaviour
{
    public Button theButton;
    void Start () {
		Button btn = theButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	public void TaskOnClick(){
		//Debug.Log ("You have clicked the button!");
		SceneManager.LoadScene("Play Scene");
	}


}


