using UnityEngine;

namespace Audios
{
    [CreateAssetMenu(
        menuName = "Audios/Load Audio Action",
        fileName = "Load Audio Action",
        order = 1
    )]
    public class LoadAudioAction : ScriptableObject
    {
        [SerializeField] private AudioSourceBuilder builder;
        [SerializeField] private ScriptableObjectAudioSource source;

        public void Invoke()
        {
            source.Impl = builder.Build();
        }
    }
}