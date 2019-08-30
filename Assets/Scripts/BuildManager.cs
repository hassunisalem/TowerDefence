﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
    }

    public GameObject standardTowerPrefab;

    private void Start()
    {
        towerToBuild = standardTowerPrefab;
    }

    private GameObject towerToBuild;

    public GameObject GetTowertToBuild()
    {
        return towerToBuild;
    }
}