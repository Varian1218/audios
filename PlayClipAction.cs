using System.Collections.Generic;
using UnityEngine;

namespace Audios
{
    public class PlayClipAction : IPlayClipAction
    {
        private IDictionary<string, AudioClip> _clips;
        private AudioSource _source;

        public IDictionary<string, AudioClip> Clips
        {
            set => _clips = value;
        }

        public AudioSource Source
        {
            set => _source = value;
        }

        public void Invoke(string hash)
        {
            _source.clip = _clips[hash];
            _source.Play();
        }
    }
}