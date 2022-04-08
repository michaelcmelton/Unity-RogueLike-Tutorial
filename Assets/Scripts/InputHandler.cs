using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{

	GameObject player;
	private bool _isMoving;
	// Start is called before the first frame update
	void Start()
	{
		player = Engine._player;
		_isMoving = false;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.W) && !_isMoving)
		{
			_isMoving = true;
			MovePlayer("up");
		}
		else if (Input.GetKeyDown(KeyCode.S) && !_isMoving)
		{
			_isMoving = true;
			MovePlayer("down");
		}
		else if (Input.GetKeyDown(KeyCode.A) && !_isMoving)
		{
			_isMoving = true;
			MovePlayer("left");
		}
		else if (Input.GetKeyDown(KeyCode.D) && !_isMoving)
		{
			_isMoving = true;
			MovePlayer("right");
		}
	}

	public void MovePlayer(string direction)
	{
		switch (direction)
		{
			case ("up"):
				float yPositive = player.transform.localPosition.y + 1.0f;
				player.transform.localPosition = new Vector3(player.transform.localPosition.x, yPositive, 0);
				break;
			case ("down"):
				float yNegative = player.transform.localPosition.y - 1.0f;
				player.transform.localPosition = new Vector3(player.transform.localPosition.x, yNegative, 0);
				break;
			case ("left"):
				float xNegative = player.transform.localPosition.x - 1.0f;
				player.transform.localPosition = new Vector3(xNegative, player.transform.localPosition.y, 0);
				break;
			case ("right"):
				float xPositive = player.transform.localPosition.x + 1.0f;
				player.transform.localPosition = new Vector3(xPositive, player.transform.localPosition.y, 0);
				break;
		}
		_isMoving = false;
	}
}
