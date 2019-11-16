using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Question : MonoBehaviour
{

    BallController other;
    public void JawabanBenar()
    {
        Debug.Log("Jawaban Benar");
        SceneManager.UnloadSceneAsync(BallController.sceneNumber);
        other.Resume();
        
    }

    public void JawabanSalah()
    {
        Debug.Log("Jawaban Salah");
        BallController.HealthCount--;
        SceneManager.UnloadSceneAsync(BallController.sceneNumber);
        other.Resume();
    }
}
