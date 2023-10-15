using UnityEngine;

public class Food : MonoBehaviour
{
    public BoxCollider2D gridArea;

    private void Start()
    {
      RandomizePosition();
    }

    public void RandomizePosition()
    {
      Bounds bounds = this.gridArea.bounds;

      float x = Random.Range(bounds.min.x, bounds.max.x);
      float y = Random.Range(bounds.min.y, bounds.max.y);

      this.transform.position = new Vector3(Mathf.Round(x), Mathf.Round(y), 0.0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
      if (other.tag == "Player")
      {
        if (this.tag == "Melon") { Time.timeScale = 1.5f; } else {
        Time.timeScale = 1f;
        }
        GetComponent<AudioSource>().Play();
        RandomizePosition();
      }
    }
}
