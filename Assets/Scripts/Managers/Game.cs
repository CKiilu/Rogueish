using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	public static Game instance = null;

	public Board boardManager;

	private int level = 3;

	void InitGame(){
		boardManager.SetupScene (level);
	}

	// Use this for initialization
	void Awake () {
		if (instance == null) {
			instance = this;
		} else if (instance == this) {
			Destroy (gameObject);
		}
		DontDestroyOnLoad (gameObject);
		boardManager = GetComponent<Board> ();
		InitGame ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
