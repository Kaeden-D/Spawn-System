using UnityEngine;

public class RedFactory : IFactory
{

    public override void SpawnCube()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.GetComponent<Renderer>().material = material;
        cube.gameObject.transform.position = new Vector3(-1, 1, 0);
        Debug.Log("Red Cube Aquired");
        cube.AddComponent<Shape>();
    }

    public override void SpawnSphere()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.GetComponent<Renderer>().material = material;
        sphere.gameObject.transform.position = new Vector3(1, 1, 0);
        Debug.Log("Sphere of Red Here");
        sphere.AddComponent<Shape>();
    }

}
