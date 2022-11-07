using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;


public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _itemsMenu;
    [SerializeField] private GameObject _aRPosition;

    void Start()
    {
        GameManager.instance.OnMainMenu += ActivateMainMenu;
        GameManager.instance.OnItemMenu += ActivateItemMenu;
        GameManager.instance.OnARPosition += ActivateARPosition;

    }

    private void ActivateMainMenu()
    {
        // Botones capa muenú se activan
        _mainMenu.transform.GetChild(0).transform.DOScale(new Vector3(1,1,1),0.3f);
        _mainMenu.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        _mainMenu.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        // Botones capa items no se activan
        _itemsMenu.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        _itemsMenu.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        _itemsMenu.transform.GetChild(1).transform.DOMoveY(180,0.3f);
        // Botones capa AR-Position no se activan
        _aRPosition.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        _aRPosition.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }

    private void ActivateItemMenu()
    {
        // Botones capa muenú no se activan
        _mainMenu.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        _mainMenu.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        _mainMenu.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        // Botones capa items se activan
        _itemsMenu.transform.GetChild(0).transform.DOScale(new Vector3(1,1,1), 0.3f);
        _itemsMenu.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        _itemsMenu.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

    }


    private void ActivateARPosition()
    {
        // Botones capa muenú no se activan
        _mainMenu.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        _mainMenu.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        _mainMenu.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        // Botones capa items no se activan
        _itemsMenu.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        _itemsMenu.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        _itemsMenu.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        // Botones capa AR-Position se activan
        _aRPosition.transform.GetChild(0).transform.DOScale(new Vector3(1,1,1), 0.3f);
        _aRPosition.transform.GetChild(1).transform.DOScale(new Vector3(1,1,1), 0.3f);
    }

   
   
   
}
