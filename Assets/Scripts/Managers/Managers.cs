using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance; // 유일성이 보장된다.
    static Managers Instance { get { Init(); return s_instance; } } // 유일한 매니저를 갖고온다, 외부에서 사용할 때 GetInstance를 사용하여 가져온다.
    InputManagers _input = new InputManagers();
    ResourceManager _resource = new ResourceManager();
    public static InputManagers Input { get { return Instance._input; } }
    public static ResourceManager Resource { get { return Instance._resource; } }
    void Start()
    {
        Init();
    }
    void Update()
    {
        _input.OnUpdate();
    }

    static void Init()
    {
        if (s_instance == null)
        {
            // 중복되는 Managers를 생성하는 것을 막기 위한 방법
            GameObject go = GameObject.Find("@Managers");
            if (go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }
            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();
        }
    }
}