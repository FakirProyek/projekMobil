using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;



public class Question : MonoBehaviour
{
    public void JawabanBenar()
    {
        Debug.Log("Jawaban Benar");
        SceneManager.UnloadSceneAsync(BallController.sceneNumber);
        BallController.stopMove = false;
        
    }

    public void JawabanSalah()
    {
        Debug.Log("Jawaban Salah");
        BallController.HealthCount--;
        SceneManager.UnloadSceneAsync(BallController.sceneNumber);
        BallController.stopMove = false;
        
    }
}
