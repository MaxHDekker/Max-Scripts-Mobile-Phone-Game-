using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleSpawn : MonoBehaviour {

    public GameObject mole;
    public float _spawnTime = 2f;
    public Transform[] spawnPoints;
	// Use this for initialization
	void Start () {

        InvokeRepeating("Spawn", _spawnTime, _spawnTime);
    }
	
	// Update is called once per frame
	void Spawn () {
        GameObject mol;
		int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        mol = Instantiate(mole, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

        Destroy(mol, 1f);
    }
}
