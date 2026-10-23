using UnityEngine;

public abstract class IFactory : MonoBehaviour
{

    [SerializeField]
    protected Material material;

    public abstract void SpawnCube();
    public abstract void SpawnSphere();
}
