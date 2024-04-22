using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T: Component
{
    private static T instance;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<T>();
                if (instance == null)
                {
                    var go = new GameObject();
                    instance = go.AddComponent<T>();
                    go.name = typeof(T).Name;
                }
            }
            return instance;
        }
    }


    public virtual void Awake()
    {
        if(instance == null)
        {
            instance = this as T;
            if(Application.isPlaying)
            {
                DontDestroyOnLoad(gameObject);
            }
        }
    }
}
