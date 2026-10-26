using UnityEngine;

public class BlueFactory : IFactory
{

    public override void SpawnCube()
    {
        GameObject cube = new GameObject();
        cube.AddComponent<BlueCube>().Spawn(material);

        /*
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.GetComponent<Renderer>().material = material;
        cube.gameObject.transform.position = new Vector3(-1, -1, 0);
        Debug.Log("Aquired Blue Cube");
        cube.AddComponent<Shape>();*/
    }

    public override void SpawnSphere()
    {
        GameObject sphere = new GameObject();
        sphere.AddComponent<BlueSphere>().Spawn(material);

        /*
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.GetComponent<Renderer>().material = material;
        sphere.gameObject.transform.position = new Vector3(1, -1, 0);
        Debug.Log("Blue Sphere Here");
        sphere.AddComponent<Shape>();*/
    }

}
