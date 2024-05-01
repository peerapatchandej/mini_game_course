using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
  float speed = -5f;

  // Start is called before the first frame update
  void Start()
  {
    
  }

  // Update is called once per frame
  void Update()
  {
    transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    int randomPosX = Random.Range(60, Camera.main.pixelWidth - 61);
    int posY = Camera.main.pixelHeight + 60;
    transform.position = Camera.main.ScreenToWorldPoint(new Vector2(randomPosX, posY));
  }
}
