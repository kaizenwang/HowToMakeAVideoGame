using UnityEngine;
using UnityEditor.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public void CompleteLevel(){
        Debug.Log("LEVEL WON!");
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart(){
       EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().name); 
    }

}
