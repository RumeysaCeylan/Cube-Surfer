using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCubeManager : MonoBehaviour
{

    private float stepLenght = 2.29f;
    private float playerstepLenght = 4.58f;


    public List<CubeBehaviour> listOfCubeBehaviours = new List<CubeBehaviour>();

    private void Awake()
    {
        Singleton();
    }

    #region Singleton

    public static PlayerCubeManager Instance;

    private void Singleton()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        Instance = this;
    }
    #endregion

    public void GetCube(CubeBehaviour cubeBehaviour)
    {
        listOfCubeBehaviours.Add(cubeBehaviour);
        cubeBehaviour.isStacked = true;

        cubeBehaviour.transform.parent = transform;

        int indexOfCube = listOfCubeBehaviours.Count - 1;


        //TODO : REORDER ALL CUBES

        ReorderCubes();

        var playerTransform = PlayerBehavior.Instance.transform;
        var yValue = listOfCubeBehaviours.Count;
        var playerTarget = new Vector3(0f,yValue,0f);

        playerTransform.DOLocalMove(playerTarget,0.05f);


    }

    private void ReorderCubes()
    {
        int index = listOfCubeBehaviours.Count - 1;

        foreach(var cube in listOfCubeBehaviours)
        {
            Vector3 target = new Vector3(0f,index*stepLenght,0f);
            cube.transform.DOLocalMove(target, 0.05f);
            index--;
        }
{}
    }
}
