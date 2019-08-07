﻿using Articy.Test;
using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    private GameController _controller;
    private PrefabManager _prefabManager;
    private ArticyFlowPlayer _flowPlayer;
    private SaveSystem _saveSystem;

    private void Awake()
    {
        _prefabManager = GetComponent<PrefabManager>();
        _flowPlayer = GetComponent<ArticyFlowPlayer>();
        _saveSystem = GetComponent<SaveSystem>();
        _controller = GetComponent<GameController>();
    }

    public GameObject SpawnPhrase(string text)
    {
        GameObject p = Instantiate(_prefabManager.phrasePrefab, _prefabManager.content);
        p.GetComponentInChildren<Text>().text = text;
        return p;
    }

    public GameObject SpawnChoice(List<Branch> candidates)
    {
        GameObject bg = SpawnButtonGroup();
        foreach (Branch p in candidates)
        {
            IObjectWithMenuText target = p.Target as IObjectWithMenuText;
            // Передаем в том числе всех кандидатов, чтобы после выбора они все залогались
            SpawnButton(bg.transform, target.MenuText, p, candidates);
        }
        return bg;
    }

    public GameObject SpawnButtonGroup()
    {
        GameObject bg = Instantiate(_prefabManager.buttonGroup, _prefabManager.content);
        return bg;
    }

    public Button SpawnButton(Transform buttonGroup, string text, Branch exit, List<Branch> candidates)
    {
        Button b = Instantiate(_prefabManager.buttonPrefab, buttonGroup);
        b.GetComponentInChildren<Text>().text = text;
        b.onClick.AddListener(() =>
        {
            //  Логаем и фразу и все кнопки только по нажатию на одну из них
            _saveSystem.LogEvent(Const.EventType.PhraseEvent, _controller.Current.Text);
            foreach (Branch branch in candidates)
            {
                _saveSystem.LogEvent(Const.EventType.ButtonEvent, ((PhraseDialogueFragment)branch.Target).MenuText);
            }
            _saveSystem.UpdateGlobalVars();

            _flowPlayer.Play(exit);
        });
        return b;
    }

    public Slider SpawnSlider(DateTime start, double delay)
    {
        double timePassed = (DateTime.Now - start).TotalMinutes;
        Slider s = Instantiate(_prefabManager.sliderPrefab, _prefabManager.content);
        s.value = (float)(timePassed / delay);
        // log slider or something
        return s;
    }
}
