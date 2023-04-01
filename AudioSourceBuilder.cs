using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

namespace Audios
{
    [CreateAssetMenu(menuName = "Audios/Audio Source Builder", fileName = "Audio Source Builder", order = 1)]
    public class AudioSourceBuilder : ScriptableObject
    {
        [SerializeField] private bool dontDestroyOnLoad;
        [SerializeField] private bool loop;
        [SerializeField] private AudioMixerGroup mixerGroup;

        public AudioSource Build()
        {
            var source = new GameObject(name.Replace("Builder", string.Empty)).AddComponent<AudioSource>();
            source.loop = loop;
            source.outputAudioMixerGroup = mixerGroup;
            if (dontDestroyOnLoad)
            {
                DontDestroyOnLoad(source.gameObject);   
            }
            return source;
        }
    }
}