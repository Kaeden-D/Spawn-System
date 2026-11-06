using UnityEngine;

public class GreenFactory : IFactory
{

    public override void SpawnCube()
    {
        GameObject cube = new GameObject();
        cube.AddComponent<GreenCube>().Spawn(material);
    }

    public override void SpawnSphere()
    {
        GameObject sphere = new GameObject();
        sphere.AddComponent<GreenSphere>().Spawn(material);
    }

}
