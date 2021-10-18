using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorWidget : MonoBehaviour {
    public Image paletteImage;
    public Text valueText;

    public Color Color {
        set {
            paletteImage.color = value;
            valueText.text = ColorUtility.ToHtmlStringRGB(value);
        }
    }
}
