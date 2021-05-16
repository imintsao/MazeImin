using UnityEngine;
using System.Collections;

public class GameManagerImin : MonoBehaviour
{

	private void Start()
	{
		BeginGame();
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			RestartGame();
		}
	}

	public MazeImin mazePrefab;

	private MazeImin mazeInstance;

	private void BeginGame() {
		mazeInstance = Instantiate(mazePrefab) as MazeImin;
		StartCoroutine(mazeInstance.Generate());
	}

	private void RestartGame() {
		StopAllCoroutines();
		Destroy(mazeInstance.gameObject);
		BeginGame();
	}
}