/* 
	Author:  Alexan Mardigian
	Assignment 8.1
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSpawner : MonoBehaviour {

	public GameObject[] prefabs;
	public const int GEM_SPAWN_RATIO = 30;

	// Use this for initialization
	void Start () {
		// infinite gem spawning function, asynchronous
		StartCoroutine(SpawnGems());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnGems() {
		while (true) {
			// instantiate a gem in this row separated by some random amount of space
			// Also, a gem has a 1 in GEM_SPAWN_RATIO chance of spawning.
			if (Random.Range(1, GEM_SPAWN_RATIO) % 2 == 0) {
				Instantiate(prefabs[Random.Range(0, prefabs.Length)], new Vector3(26, Random.Range(-10, 10), 10), Quaternion.identity);
			}

			// pause 1-5 seconds until the next coin spawns
			yield return new WaitForSeconds(Random.Range(1, 5));
		}
	}
}
