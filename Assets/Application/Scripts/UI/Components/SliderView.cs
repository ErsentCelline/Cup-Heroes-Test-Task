using UnityEngine;
using UnityEngine.UI;

namespace UI.Components
{
    [RequireComponent(typeof(Slider))]
    public class SliderView : MonoBehaviour
    {
        private Slider _slider;

        private void Awake()
        {
            _slider = GetComponent<Slider>();
        }

        public void UpdateValue(float value)
        {
            _slider.value = value;
        }
    }
}