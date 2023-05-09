using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MitosisSpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject parentEnemy;

    [SerializeField]
    public GameObject EnemyBirth;

    [SerializeField]
    public float EnemyInterval = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy(EnemyInterval, EnemyBirth, parentEnemy));
    }

    private IEnumerator SpawnEnemy(float interval, GameObject enemy, GameObject parentEnemy)
    {
        Vector3 parentPos = parentEnemy.transform.position;
        Vector3 spawnPos = parentPos;
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, spawnPos, Quaternion.identity);
        StartCoroutine(SpawnEnemy(interval, enemy, newEnemy));

    }

}
