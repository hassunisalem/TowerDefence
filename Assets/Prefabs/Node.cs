using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    private Renderer rend;
    private GameObject towerr;

    private GameObject tsower;
    public Color hoverColor;
    private Color startColor;
    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    private void OnMouseEnter()
    {
        rend.material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
     void OnMouseDown()
    {
        if (towerr != null)
        {
            print("Can't build there");
            return;
        }
        GameObject towerToBuild = BuildManager.instance.GetTowertToBuild();
        towerr = (GameObject)Instantiate(towerToBuild, transform.position, transform.rotation);

    }
}

