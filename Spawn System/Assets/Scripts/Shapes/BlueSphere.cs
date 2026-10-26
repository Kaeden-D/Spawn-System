using UnityEngine;

public class BlueSphere : MonoBehaviour
{
    public void Spawn(Material material)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.SetParent(this.transform, false);
        sphere.GetComponent<Renderer>().material = material;
        sphere.gameObject.transform.position = new Vector3(1, -1, 0);
        Debug.Log("Blue Sphere Here");
        this.gameObject.AddComponent<Shape>();
    }
}
