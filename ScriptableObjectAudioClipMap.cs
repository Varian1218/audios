using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Audios
{
    [CreateAssetMenu(fileName = "Audio Clip Map", menuName = "Audios/Audio Clip Map", order = 1)]
    public class ScriptableObjectAudioClipMap : ScriptableObject, ISerializationCallbackReceiver
    {
        [SerializeField] private AudioClipPair[] clips;
        private Dictionary<string, AudioClip> _clips;
        public AudioClip this[string key] => _clips[key];

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
            _clips = clips.ToDictionary(it => it.hash, it => it.clip);
        }
    }
}