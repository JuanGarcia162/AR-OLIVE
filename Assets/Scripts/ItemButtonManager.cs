//Librerias
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButtonManager : MonoBehaviour
{
    //Creacion de los Atributos que seran asignados a el DataManager con respecto a el item asociado
    private string itemName;
    private string itemDescription;
    private Sprite itemImage;
    private GameObject item3DModel;
    private ARInteractionManager interactionManager;

    //Propiedades para controlar el acceso a el atributo
    public string ItemName
    {
        set
        {
            itemName = value;
        }
    }
    //Propiedades para controlar el acceso a el atributo (Es lo mismo) pero mas corto
    public string ItemDescription { set => itemDescription = value; }
    public Sprite ItemImage { set => itemImage = value; }
    public GameObject Item3DModel { set => item3DModel = value; }

    // Start is called before the first frame update
    void Start()
    {
        //Cuando se crea el boton, se asignan automaticamente los valores
        transform.GetChild(0).GetComponent<Text>().text = itemName;
        transform.GetChild(1).GetComponent<RawImage>().texture = itemImage.texture;
        transform.GetChild(2).GetComponent<Text>().text = itemDescription;

        var button = GetComponent<Button>();
        button.onClick.AddListener(GameManager.instance.ARPosition);
        button.onClick.AddListener(Create3DModel);

        interactionManager = FindObjectOfType<ARInteractionManager>();

    }
    //Creacion del modelo 3D elegido
    private void Create3DModel()
    {
        interactionManager.Item3DModel = Instantiate(item3DModel);
    }

}
