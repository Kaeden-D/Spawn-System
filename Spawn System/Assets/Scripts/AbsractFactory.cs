using UnityEngine;

public class AbsractFactory : MonoBehaviour
{

    [SerializeField]
    private RedFactory _redFactory;
    [SerializeField]
    private BlueFactory _blueFactory;
    [SerializeField]
    private GreenFactory _greenFactory;

    private IFactory _curFactory = null;

    private void OnGUI()
    {
        if (_curFactory != null && GUILayout.Button("Spawn Shape"))
        {
            if ((int)Time.time % 2 == 0)
                _curFactory.SpawnCube();
            else
                _curFactory.SpawnSphere();
        }
        if (_curFactory != null && GUILayout.Button("Spawn Shapes"))
        {
            _curFactory.SpawnCube();
            _curFactory.SpawnSphere();
        }

        if (_curFactory != _redFactory && GUILayout.Button("Change Color To Red"))
        {
            _curFactory = _redFactory;
        }
        if (_curFactory != _greenFactory && GUILayout.Button("Change Color To Green"))
        {
            _curFactory = _greenFactory;
        }
        if (_curFactory != _blueFactory && GUILayout.Button("Change Color To Blue"))
        {
            _curFactory = _blueFactory;
        }
    }

}
