using UnityEngine;

public class RedCube : MonoBehaviour
{
    public void Spawn(Material material)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(this.transform, false);
        cube.GetComponent<Renderer>().material = material;
        cube.gameObject.transform.position = new Vector3(-1, 1, 0);
        Debug.Log("Red Cube Aquired");
        this.gameObject.AddComponent<Shape>();
    }
}
