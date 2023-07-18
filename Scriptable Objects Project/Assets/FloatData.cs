using UnityEngine;

[CreateAssetMenu]

public class FloatData : ScriptableObject {
    public float value;

    public void UpdateValue(float num) {
        value += num;
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        UpdateLabel().text = dataObj.value.ToString();

    }

}