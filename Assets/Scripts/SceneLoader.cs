using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.Events;

public class SceneLoader : MonoBehaviour {

    [SerializeField]
    private RawImage fadeImage;

    [SerializeField]
    private float duration = 0.5f;

    public static SceneLoader singleton;

    public UnityEvent onFinishFade;

    public void Awake()
    {
        singleton = this;
        fadeImage.color = Color.black;
        StartCoroutine(IntroFade());
    }

    public void changeScene(string nextScene)
    {
        StartCoroutine(changeSceneFade(nextScene));
    }

    IEnumerator changeSceneFade(string nextScene)
    {
        float startTime = Time.time;
        float normTime = 0;

        fadeImage.enabled = true;
        while (normTime < 1)
        {
            normTime = (Time.time - startTime) / duration;
            fadeImage.color = Color.Lerp(Color.clear, Color.black, normTime);
            yield return null;
        }
        SceneManager.LoadScene(nextScene, LoadSceneMode.Single);
    }

    IEnumerator IntroFade()
    {
        fadeImage.enabled = true;
        float startTime = Time.time;
        float normTime = 0;

        while (normTime < 1)
        {
            normTime = (Time.time - startTime) / duration;
            fadeImage.color = Color.Lerp(Color.black, Color.clear, normTime);
            yield return null;
        }
        fadeImage.enabled = false;
        onFinishFade.Invoke();
    }



}
