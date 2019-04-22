using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{

    // Use this for initialization
    public GameObject LoadingScenePanel;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            StartCoroutine(LoadAsynchronously(0));
        }
    }

    public void BacktoMainMenuFunction(){
        StartCoroutine(LoadAsynchronously(0));
    }


    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        // Start to asynchrously change the scene
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        // Show the loading panel
        LoadingScenePanel.SetActive(true);

        while (!operation.isDone)
        {
            // float progress = Mathf.Clamp01(operation.progress / .9f);

            // slider.value = progress;
            yield return null;
        }
    }
}
