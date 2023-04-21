using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Audios
{
    public static class AudioUtils
    {
        public static void Load(
            ScriptableObjectPlayClipAction action,
            IEnumerable<AudioClip> clips,
            AudioSource source
        )
        {
            source = Object.Instantiate(source);
            Object.DontDestroyOnLoad(source);
            action.Impl = new PlayClipAction
            {
                Clips = clips.ToDictionary(it => it.name),
                Source = source,
            };
        }
    }
}