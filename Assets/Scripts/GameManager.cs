//Librerias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    //Eventos que manejaran los estados de la aplicacion
    public event Action OnMainMenu;
    public event Action OnItemsMenu;
    public event Action OnARPosition;

    //Creacion del Singleton (Patron de diseño)
    public static GameManager instance;
    private void Awake()
    {
        //Nos aseguramos de que solo exista una instancia del GameManager
        if (instance!= null && instance!= this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //Cuando se inicie la aplicacion inmediatamente llama a la funcion MainMenu
        MainMenu();
    }

    //Creacion de funciones para llamar a los eventos
    public void MainMenu()
    {
        OnMainMenu?.Invoke();
        Debug.Log("Main Menu Activated");
    }

    public void ItemsMenu()
    {
        OnItemsMenu?.Invoke();
        Debug.Log("Items Menu Activated");
    }

    public void ARPosition()
    {
        OnARPosition?.Invoke();
        Debug.Log("AR Position Activated");
    }
    //Accion que cierra la aplicacion
    public void closeAPP()
    {
        Application.Quit(); 
    }
}
