using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeSceneInThree());
    }

    private IEnumerator ChangeSceneInThree()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(1);
    }
}
