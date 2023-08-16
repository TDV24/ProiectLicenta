using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using Unity.VisualScripting;
using System;

public class DropdownImagesMatch : MonoBehaviour
{
    public Image oldImage;
    public Sprite[] newImage;
    public TMP_Dropdown teamsMenu;
    public TMP_Text oldRiders;
    public TextAsset[] newRiders;

    public void changeImage(TMP_Dropdown teamsMenu)
    {
        oldImage.sprite = newImage[teamsMenu.value];
    }

    public void changeTeam(TMP_Dropdown teamsMenu)
    {
        oldImage.sprite = newImage[teamsMenu.value];
        oldRiders.text = newRiders[teamsMenu.value].text;
    }
}
