using UnityEngine;
using UnityEditor.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().buildIndex + 1);
    }
}
