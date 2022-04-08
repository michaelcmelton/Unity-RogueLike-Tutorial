using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{

	public static GameObject _player;
	// Start is called before the first frame update
	void Start()
	{
		GameObject playerObject = Resources.Load<GameObject>("Prefabs/Player");
		_player = Instantiate(playerObject, new Vector3(0, 0, 0), Quaternion.identity);
	}

	// Update is called once per frame
	void Update()
	{

	}
}
