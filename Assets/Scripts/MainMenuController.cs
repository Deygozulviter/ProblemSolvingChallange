﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{ 
    [SerializeField] private Button button1;
    [SerializeField] private Button button2;
    [SerializeField] private Button button3;
    [SerializeField] private Button button4;
    [SerializeField] private Button button5;
    [SerializeField] private Button button6;
    [SerializeField] private Button button7;
    [SerializeField] private Button button8;
    [SerializeField] private Button button9;

    private void Start()
    {
        button1.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(0);
        });

        button2.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(1);
        });

        button3.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(2);
        });

        button4.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(3);
        });

        button5.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(4);
        });

        button6.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(5);
        });

        button7.onClick.AddListener(() =>
       {
            SceneManager.LoadScene(6);
        });

        button8.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(7);
        });

        button9.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(8);
        });
    }
}