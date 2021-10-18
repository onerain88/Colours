using System;
using System.Reflection;
using System.Linq;
using UnityEngine;

public class ColorPalette : MonoBehaviour {
    public GameObject colorWidgetPrefab;

    void Start() {
        Type coloursType = typeof(Colours);
        FieldInfo[] colorFields = coloursType.GetFields(BindingFlags.Public | BindingFlags.Static)
            .Where(field => field.FieldType == typeof(Color))
            .ToArray();
        foreach (FieldInfo colorField in colorFields) {
            Color color = (Color) colorField.GetValue(null);
            Debug.Log(color);
            GameObject colorWidgetGO = Instantiate(colorWidgetPrefab);
            colorWidgetGO.transform.SetParent(transform);

            ColorWidget colorWidget = colorWidgetGO.GetComponent<ColorWidget>();
            colorWidget.Color = color;
        }
    }
}
