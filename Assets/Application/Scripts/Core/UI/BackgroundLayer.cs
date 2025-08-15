using Core.UI.SO;
using UnityEngine;
using UnityEngine.UI;

namespace Core.UI
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class BackgroundLayer : MonoBehaviour
    {
        [SerializeField] private BackgroundLayerConfig _layerConfig;

        private SpriteRenderer _image;
        
        private void Awake()
        {
            _image = GetComponent<SpriteRenderer>();

            _image.material = new Material(_layerConfig.InitialMaterial);
            _image.material.SetFloat("_scrollSpeed", _layerConfig.InitialScrollSpeed);
        }
    }
}