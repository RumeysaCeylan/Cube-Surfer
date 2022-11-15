using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

    [SerializeField] 
    private Animator animatorOfPlayer;

    private void Awake()
    {
        Singleton();
    }

    #region Singleton

    public static PlayerBehavior Instance;

    private void Singleton()
    {
        if(Instance!=null && Instance == this)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }
    #endregion
}
