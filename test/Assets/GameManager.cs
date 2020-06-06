/* using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;


    public void EndGame ()
    {
        //Debug.Log("GAME OVER");
        Restart();
    }
        
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }    

} */
