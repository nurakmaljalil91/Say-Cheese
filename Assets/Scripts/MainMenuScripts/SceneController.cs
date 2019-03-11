using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneController : MonoBehaviour
{

    public GameObject LoadingScenePanel;
    public Slider slider;
    // Play game
    public void PlayGame(int sceneIndex)
    {
		StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
		// Start to asynchrously change the scene
		AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

		// Show the loading panel
		LoadingScenePanel.SetActive(true);

		while(!operation.isDone){
			float progress = Mathf.Clamp01(operation.progress / .9f);

			slider.value = progress;
			yield return null;
		}
    }
}
