using UnityEngine;

public class Shape : MonoBehaviour
{

    private float spawnTime;

    private void Start()
    {
        spawnTime = Time.time;
    }

    private void Update()
    {
        if (spawnTime + 1 <= Time.time)
        {
            Destroy(this.gameObject);
        }
    }

}
