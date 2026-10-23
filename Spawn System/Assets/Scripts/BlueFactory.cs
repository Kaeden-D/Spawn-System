using UnityEngine;

public class BlueFactory : IFactory
{

    public override void SpawnCube()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.GetComponent<Renderer>().material = material;
        cube.gameObject.transform.position = new Vector3(-1, -1, 0);
        Debug.Log("Aquired Blue Cube");
        cube.AddComponent<Shape>();
    }

    public override void SpawnSphere()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.GetComponent<Renderer>().material = material;
        sphere.gameObject.transform.position = new Vector3(1, -1, 0);
        Debug.Log("Blue Sphere Here");
        sphere.AddComponent<Shape>();
    }

}
