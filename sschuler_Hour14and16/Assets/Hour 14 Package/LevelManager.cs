using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public string sceneToLoad = "sschuler_Hour16";


	public void LoadGame()
	{
		SceneManager.LoadScene("sschuler_Hour16");
	}
}
