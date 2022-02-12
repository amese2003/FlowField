using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    static Managers s_instance;

    public static Managers Instance { get { Init(); return s_instance;} }

    #region Contentes
    #endregion

    #region Core
    PoolManager _pool = new PoolManager();
    SceneManagerEx _scene = new SceneManagerEx();
    ResourceManager _resource = new ResourceManager();
    UIManager _ui = new UIManager();
    DataManager _data = new DataManager();

    public static PoolManager Pool { get { return Instance._pool; } }
    public static SceneManagerEx Scene { get { return Instance._scene; } }
    public static ResourceManager Resource { get { return Instance._resource; } }
    public static UIManager UI { get { return Instance._ui; } }
    public static DataManager Data { get { return Instance._data; } }
    #endregion

    private void Start()
    {
        Init();
    }

    private void Update()
    {
        
    }

    static void Init()
    {
        if (s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");

            if (go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Managers>();
            }

            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Managers>();

            // TODO Init
            s_instance._pool.Init();

        }
    }

    public static void Clear()
    {
        // todo
        Pool.Clear();
    }

}
