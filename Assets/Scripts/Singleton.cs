using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>  
{
    private T instance;
    public T Instance
    {
        get
        {
            //se tiver ref retorna
            if(instance != null) return instance;

            //senao acha um e retorna
            instance = FindObjectOfType<T>();
            if(instance != null) return instance;

            //senao cria um e retorna
            instance = new GameObject().AddComponent<T>();
            return instance;
        }
    }
}
