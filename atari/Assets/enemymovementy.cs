using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovementy : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float speed;

    void FixedUpdate()
    {
        enemy.transform.Translate(0, speed * Time.deltaTime, 0);
    }

}
