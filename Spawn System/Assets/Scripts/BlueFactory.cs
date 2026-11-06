using UnityEngine;

public class BlueFactory : IFactory
{

    public override void SpawnCube()
    {
        GameObject cube = new GameObject();
        cube.AddComponent<BlueCube>().Spawn(material);
    }

    public override void SpawnSphere()
    {
        GameObject sphere = new GameObject();
        sphere.AddComponent<BlueSphere>().Spawn(material);
    }

}
