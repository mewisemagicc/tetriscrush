using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Destroy : MonoBehaviour
    
{
    // Start is called before the first frame update
    [SerializeField] private TextMeshProUGUI _text;
    void OnTriggerEnter(Collider other)
    {
      
        if (other.gameObject.CompareTag("shape"))
        {
            spawner.instance.Spawn2();
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);
            Score.totalScore++;
            _text.text = Score.totalScore.ToString();

        }
        //if (other.gameObject.CompareTag("win"))
        //{
            
        //    gameObject.SetActive(false);

        //    Score.totalScore++;
        //    _text.text = Score.totalScore.ToString();
        //}
    }
}
