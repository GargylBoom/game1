using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class vectorjump : MonoBehaviour
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
        Vector2 pos = EnemySpawn.position + new Vector3(0, Random.Range(-range.y, range.y));
        Instantiate(enemy, pos , Quaternion.identity);
        Repeat();
    }
    void Repeat()
    {
        StartCoroutine(Spawn());
    }
}
