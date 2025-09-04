
using UnityEngine;
using UnityEngine.SceneManagement; // 꼭 필요!

public class RestartGame : MonoBehaviour
{
    public void RestartScene()
    {
        // 현재 실행 중인 씬 이름 가져오기
        string currentScene = SceneManager.GetActiveScene().name;

        // 현재 씬 다시 로드
        SceneManager.LoadScene(currentScene);
    }
}

