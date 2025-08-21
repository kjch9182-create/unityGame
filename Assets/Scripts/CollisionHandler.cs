using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision Collision)
    {
         switch (Collision.gameObject.tag)
         {
             case "Start":
              Debug.Log("시작합니다");
              break;

             case "Finish":
              Debug.Log("도착");
              break;

             case "Fuel":
              Debug.Log("연료를 얻었다!");
              break;

             default:
              ReloadLevel();
              break;
         }
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(0);
    }
}
