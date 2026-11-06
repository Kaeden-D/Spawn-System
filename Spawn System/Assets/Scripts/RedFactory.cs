using UnityEngine;

public class RedFactory : IFactory
{

    public override void SpawnCube()
    {
        GameObject cube = new GameObject();
        cube.AddComponent<RedCube>().Spawn(material);
    }

    public override void SpawnSphere()
    {
        GameObject sphere = new GameObject();
        sphere.AddComponent<RedSphere>().Spawn(material);
    }

}
