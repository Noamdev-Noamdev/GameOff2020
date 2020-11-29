using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisionLava : MonoBehaviour
{
	public int Respawn;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.name == "lava")
		{
			SceneManager.LoadScene(Respawn);
		}
	}
}
