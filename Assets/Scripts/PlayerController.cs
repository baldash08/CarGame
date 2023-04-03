using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    float verticalInput;
    private int score;
    private int live;
    [SerializeField]private TextMeshProUGUI scoreText;
    [SerializeField]private TextMeshProUGUI liveText;
    // Start is called before the first frame update
    void Awake()
    {
        score = 0;
        live = 3;
        StartCoroutine(AddScore());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * verticalInput * speed);    
        Debug.Log($"score: {score}");
        scoreText.text = "Score: " + score.ToString();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("OnCollision");
            PhysicMetod(collision);
            if (live >= 1)
            {
                live -= 1;
                liveText.text = "Lives: " + live;
            } else
            {
                Data.score = score;
                if (Data.recordScore < Data.score)
                {
                    Data.recordScore = Data.score;
                }
                GameManager.gm.LoadScene(2);
            }
        }
        if (collision.gameObject.CompareTag("Border"))
        {
            Debug.Log("Border collision");
            PhysicMetod(collision);
        }
    }

    private void PhysicMetod(Collision2D collision)
    {
        if (collision.gameObject.transform.position.x > gameObject.transform.position.x)
        {
            gameObject.transform.position = new Vector3(collision.gameObject.transform.position.x - 2.2f, -3f, 0);
        }
        else
        {
            gameObject.transform.position = new Vector3(2.2f + collision.gameObject.transform.position.x, -3f, 0);
        }
    }

    IEnumerator AddScore()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            score++;
        }
    }
}
