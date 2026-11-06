using UnityEngine;

public class GreenSphere : MonoBehaviour
{
    public void Spawn(Material material)
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.SetParent(this.transform, false);
        sphere.GetComponent<Renderer>().material = material;
        sphere.gameObject.transform.position = new Vector3(1, 0, 0);
        Debug.Log("Here is a Green Sphere");
        this.gameObject.AddComponent<Shape>();
    }
}
