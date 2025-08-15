using TMPro;
using UnityEngine;

namespace UI.Components
{
    [RequireComponent(typeof(TMP_Text))]
    public class ValueView : MonoBehaviour
    {
        private TMP_Text _valueField;

        private void Awake()
        {
            _valueField = GetComponent<TMP_Text>();
        }

        public void UpdateValue(string value)
        {
            _valueField.text = value;
        }
    }
}