using UnityEngine;

public class GreenCube : MonoBehaviour
{
    public void Spawn(Material material)
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(this.transform, false);
        cube.GetComponent<Renderer>().material = material;
        cube.gameObject.transform.position = new Vector3(-1, 0, 0);
        Debug.Log("Aquired a Green Cube");
        this.gameObject.AddComponent<Shape>();
    }
}
