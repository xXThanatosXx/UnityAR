using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public event Action OnMainMenu;
    public event Action OnItemMenu;
    public event Action OnARPosition;

    public static GameManager instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {

            Destroy(gameObject);

        }

        else
        {
            instance = this;
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenu()
    {
        OnMainMenu?.Invoke();
        Debug.Log("Menu activado");
    }

    public void ItemsMenu()
    {
        OnItemMenu?.Invoke();
        Debug.Log("Items del menú activados");
    }
    public void ARPosition()
    {
        OnARPosition?.Invoke();
        Debug.Log("items en posición");
    }

    public void ExitAPP()
    {
        Application.Quit();
    }

}
