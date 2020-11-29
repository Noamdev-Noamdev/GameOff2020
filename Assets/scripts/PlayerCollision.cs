using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
	public int Respawn;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if(collision.gameObject.name=="alien")
        {
			SceneManager.LoadScene(Respawn);
		}
	}
}
