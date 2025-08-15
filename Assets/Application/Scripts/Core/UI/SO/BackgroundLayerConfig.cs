using UnityEngine;

namespace Core.UI.SO
{
    /// <summary>
    /// Always require decrease Order Layer
    /// </summary>
    [CreateAssetMenu(fileName = "BackgroundLayerConfig", menuName = "Scriptable Objects/BackgroundLayerConfig")]
    public class BackgroundLayerConfig : ScriptableObject
    {
        [SerializeField, Range(0, 0.25f)] public float InitialScrollSpeed = 0;
        [SerializeField] public Material InitialMaterial;
    }
}