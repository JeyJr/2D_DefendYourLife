using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIAttributes : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private LobbyUIController lobbyUI;

    [Header("Attribute Points")]
    [SerializeField] private int attributePoints;
    [SerializeField] private int usedAttributePoints;

    [Header("TextMeshPro")]
    [SerializeField] private TextMeshProUGUI txtTitle;
    [SerializeField] private TextMeshProUGUI txtAttributePoints;
    [SerializeField] private TextMeshProUGUI txtStrValue;
    [SerializeField] private TextMeshProUGUI txtIntValue;
    [SerializeField] private TextMeshProUGUI txtVitValue;
    [SerializeField] private TextMeshProUGUI txtLukValue;

    [Header("Sliders")]
    [SerializeField] private Slider sStr;
    [SerializeField] private Slider sInt;
    [SerializeField] private Slider sVit;
    [SerializeField] private Slider sLuk;

    private void Start()
    {
        AttributePointsControl();
        sStr.maxValue = 100;
        sInt.maxValue = 100;
        sVit.maxValue = 100;
        sLuk.maxValue = 100;
    }

    void AttributePointsControl()
    {
        usedAttributePoints = (lobbyUI.Str - 1) + (lobbyUI.Inte - 1) + (lobbyUI.Vit - 1) + (lobbyUI.Luk - 1);
        attributePoints = (lobbyUI.Level * 3) - usedAttributePoints;
    }

    private void Update()
    {
        if(panel.activeSelf == true)
        {
            AttributePointsControl();
            txtTitle.text = "Attributes";
            txtStrValue.text = lobbyUI.Str.ToString();
            txtIntValue.text = lobbyUI.Inte.ToString();
            txtVitValue.text = lobbyUI.Vit.ToString();
            txtLukValue.text = lobbyUI.Luk.ToString();
            txtAttributePoints.text = attributePoints.ToString();

            sStr.value = lobbyUI.Str;
            sInt.value = lobbyUI.Inte;
            sVit.value = lobbyUI.Vit;
            sLuk.value = lobbyUI.Luk;
        }
    }


    public void AddAttributePoints(string attributeName)
    {
        if (attributePoints > 0)
        {
            switch (attributeName)
            {
                case "Str":
                    if (lobbyUI.Str < 100)
                    {
                        lobbyUI.Str++;
                        attributePoints--;
                    }
                    break;
                case "Int":
                    if (lobbyUI.Inte < 100)
                    {
                        lobbyUI.Inte++;
                        attributePoints--;
                    }
                    break;
                case "Vit":
                    if (lobbyUI.Vit < 100)
                    {
                        lobbyUI.Vit++;
                        attributePoints--;
                    }
                    break;
                case "Luk":
                    if (lobbyUI.Luk < 100)
                    {
                        lobbyUI.Luk++;
                        attributePoints--;
                    }
                    break;
            }
        }
    }
    public void SubtractAttributePoints(string attributeName)
    {
        if (usedAttributePoints > 0)
        {
            switch (attributeName)
            {
                case "Str":
                    if (lobbyUI.Str > 1)
                    {
                        lobbyUI.Str--;
                        attributePoints++;
                    }
                    break;
                case "Int":
                    if (lobbyUI.Inte > 1)
                    {
                        lobbyUI.Inte--;
                        attributePoints++;
                    }
                    break;
                case "Vit":
                    if (lobbyUI.Vit > 1)
                    {
                        lobbyUI.Vit--;
                        attributePoints++;
                    }
                    break;
                case "Luk":
                    if (lobbyUI.Luk > 1)
                    {
                        lobbyUI.Luk--;
                        attributePoints++;
                    }
                    break;
            }
        }
    }

}
