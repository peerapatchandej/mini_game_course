using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
  float speed = 5f;
  float horizontal = 0f;
  int score = 0;
  TextMeshProUGUI scoreText;

  // Start is called before the first frame update
  void Start()
  {
    GameObject scoreObject = GameObject.Find("ScoreText");
    scoreText = scoreObject.GetComponent<TextMeshProUGUI>();
    scoreText.text = "0";
  }

  // Update is called once per frame
  void Update()
  {
    horizontal = Input.GetAxisRaw("Horizontal");
    transform.position = new Vector2(transform.position.x + speed * horizontal * Time.deltaTime, transform.position.y);
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    score = score + 1;
    scoreText.text = score.ToString();
  }
}
