using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI recordText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + Data.score;
        recordText.text = "Record: " + Data.recordScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
