using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPause : MonoBehaviour
{

    //the ButtonPauseMenu
    public GameObject ingameMenu;
    public AudioSource audio;

    public void OnPause()//�������ͣ��ʱִ�д˷���
    {
        Time.timeScale = 0;
        ingameMenu.SetActive(true);
    }

    public void OnResume()//������ص���Ϸ��ʱִ�д˷���
    {
        Time.timeScale = 1f;

        audio.Play();
        ingameMenu.SetActive(false);
    }

    public void OnRestart()//��������¿�ʼ��ʱִ�д˷���
    {
        //Loading Scene0
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}