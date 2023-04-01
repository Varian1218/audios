using UnityEngine;

namespace Audios
{
    [CreateAssetMenu(menuName = "Audios/Audio Source", fileName = "Audio Source", order = 1)]
    public class ScriptableObjectAudioSource : ScriptableObject
    {
        private AudioSource _impl;

        public AudioSource Impl
        {
            set => _impl = value;
        }

        public void Play(AudioClip clip)
        {
            _impl.clip = clip;
            _impl.Play();
        }
    }
}