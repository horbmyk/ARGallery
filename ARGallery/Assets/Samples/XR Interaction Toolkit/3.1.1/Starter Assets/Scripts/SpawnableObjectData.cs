namespace UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets
{
    [CreateAssetMenu(fileName = "SpawnableObjectData", menuName = "ARGallery/Spawnable Object Data")]
    public class SpawnableObjectData : ScriptableObject
    {
        public GameObject prefab;
        [TextArea]
        public string description;
    }
}
