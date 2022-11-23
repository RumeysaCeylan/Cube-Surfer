using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button : MonoBehaviour
{
    
    // Update is called once per frame
    public void RestartGame()
    {
        CoinText.coinAmount = 0;
        Scene scene;
        scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public void QuitButton()
    {
        SceneManager.LoadScene(0);
    }
}
