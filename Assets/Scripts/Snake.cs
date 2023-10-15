using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Snake : MonoBehaviour
{
 private Vector2 _direction = Vector2.right;

 private List<Transform> _segments = new List<Transform>();

 public int InitialSize = 4;
 public bool breaker;
 public int colorInt = 0;

 public Sprite wpiSprite;

 public Sprite googlySprite;

 public Text highScore;

 public Transform segmentPrefab;

 private SnakeManager snakeManager;

 private bool MovingLeft;
 private bool MovingRight;
 private bool MovingUp;
 private bool MovingDown;

/* private void PauseAuto() {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Escape)) { Time.timeScale = 0f; }
        else { Time.timeScale = 1f; }
}
*/

private void Awake()
{
    MovingRight = true;
    MovingLeft  = false;
    MovingUp    = false;
    MovingDown  = false;
}

 private void Start()
 {
    colorInt = PlayerPrefs.GetInt("color");
       Debug.Log(colorInt);
       if (colorInt <= 99) {
        GetComponent<SpriteRenderer>().color = SnakeManager.colorsArray[colorInt];
        segmentPrefab.GetComponent<SpriteRenderer>().color = SnakeManager.colorsArray[colorInt];
       }
       else {
        Debug.Log("image skin");
        GetComponent<SpriteRenderer>().color = Color.white;
        if (colorInt == 100) {
          GetComponent<SpriteRenderer>().sprite = wpiSprite;
          segmentPrefab.GetComponent<SpriteRenderer>().color = Color.red;
        }
        else if (colorInt == 101) {
          GetComponent<SpriteRenderer>().sprite = googlySprite;
        }
       }
   ResetState();
   SnakeManager.doSomething();
 }

 private void Update()
 {
//   PauseAuto();
   if (SnakeManager.skinNum == 6) {
     //colorInt = SnakeManager.skinNum;
     Debug.Log("Skin is pink (Snake)");
   }

   if(Input.GetKeyDown(KeyCode.W) && MovingDown == false) {
     _direction = Vector2.up;

     //MovingUp = true;
     MovingRight = false;
     MovingLeft  = false;
     MovingUp    = true; // Set to TRUE
     MovingDown  = false;
   }

   else if(Input.GetKeyDown(KeyCode.S) && MovingUp == false) {
     _direction = Vector2.down;

     //MovingDown = true;
     MovingRight = false;
     MovingLeft  = false;
     MovingUp    = false;
     MovingDown  = true; // Set to TRUE
   }

   else if(Input.GetKeyDown(KeyCode.A) && MovingRight == false) {
     _direction = Vector2.left;

     // MovingLeft = true;
     MovingRight = false;
     MovingLeft  = true; // Set to TRUE
     MovingUp    = false;
     MovingDown  = false;
   }

   else if(Input.GetKeyDown(KeyCode.D) && MovingLeft == false) {
     _direction = Vector2.right;

     // MovingRight = true;
      MovingRight = true; // Set to TRUE
      MovingLeft  = false;
      MovingUp    = false;
      MovingDown  = false;
   }
 }

 private void FixedUpdate()
 {
  for (int i = _segments.Count - 1; i > 0; i--)
  {
    _segments[i].position = _segments[i-1].position;
  }

  this.transform.position = new Vector3(
  Mathf.Round(this.transform.position.x) + _direction.x,
  Mathf.Round(this.transform.position.y) + _direction.y,
  0.0f
  );
 }

 private void Grow()
 {
   Transform segment = Instantiate(this.segmentPrefab);
   segment.position = _segments[_segments.Count - 1].position;
   _segments.Add(segment);
   if((_segments.Count - InitialSize) > PlayerPrefs.GetInt("HighScore",0)) {
       PlayerPrefs.SetInt("HighScore",(_segments.Count - InitialSize));
       highScore.text = (_segments.Count - InitialSize).ToString();
   }
}

 public void ResetState()
 {
   highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();

   // Debug.Log("Resetting State");
   for (int i = 1; i < _segments.Count; i++)
   {
     Destroy(_segments[i].gameObject);
   }

   _segments.Clear();
   _segments.Add(this.transform);

   for (int i = 1; i < this.InitialSize; i++)
   {
      _segments.Add(Instantiate(this.segmentPrefab));
   }

   this.transform.position = Vector3.zero;
 }

 private void OnTriggerEnter2D(Collider2D other)
     {
       if (other.tag == "Food")
       {
         Grow();
       }

       if (other.tag == "Melon")
       {
         Grow();
         Grow();
       }

       else if (other.tag == "Obstacle")
       {
         GetComponent<AudioSource>().Play();
         breaker = false;
         ResetState();
       }
     }

}
