using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class destroy : MonoBehaviour
{
    public int score;
    [SerializeField] Text ScoreText;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);


            score++;
        }
    }
    void Update()
    {
        ScoreText.text = score.ToString();
    }

}



