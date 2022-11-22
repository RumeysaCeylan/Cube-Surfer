using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelText : MonoBehaviour
{
    Text text;
    public static int level=1;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene;
        scene = SceneManager.GetActiveScene();
        
        text.text = "Level "+ scene.name; 


    }
}
