using UnityEngine;

public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance
    {
        get
        {
            return instance;
        }
    }

    private enum DontDestroyType { Yes, No }

    private static T instance;

    [Tooltip("Set this before runtime.")] [SerializeField] DontDestroyType dontDestroyOnLoad = DontDestroyType.No;

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as T;

            if (dontDestroyOnLoad == DontDestroyType.Yes)
            {
                DontDestroyOnLoad(gameObject);
            }
        }
        else
        {
            Destroy(gameObject);
        }
    }
}