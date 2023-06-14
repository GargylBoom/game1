using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemymovex : MonoBehaviour
{
    public Transform EnemySpawn;
    private Vector2 enemys;
    [SerializeField] Vector2 range;
    [SerializeField] GameObject enemy;

    public void Start()
    {
        StartCoroutine(Spawn());
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1);
        Vector2 pos = EnemySpawn.position + new Vector3(Random.Range(-range.x, range.x), 0);
        Instantiate(enemy, pos, Quaternion.identity);
        Repeat();
    }
    void Repeat()
    {
        StartCoroutine(Spawn());
    }
}
