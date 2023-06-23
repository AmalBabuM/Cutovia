using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopGameManager : MonoBehaviour
{
    public static TopGameManager Instance;

    public GameObject[] Level;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void Display()
    {
        Debug.Log("Hi");
    }

}
