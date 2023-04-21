using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Audios
{
    [CreateAssetMenu(fileName = "Audio Clip Array", menuName = "Audios/Audio Clip Array", order = 1)]
    public class ScriptableObjectClipArray : ScriptableObject, IEnumerable<AudioClip>
    {
        [SerializeField] private AudioClip[] clips;

        public IEnumerator<AudioClip> GetEnumerator()
        {
            return clips.Select(it => it).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return clips.GetEnumerator();
        }
    }
}