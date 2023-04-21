using System;
using UnityEngine;

namespace Audios
{
    [Serializable]
    public struct AudioClipPair
    {
        public AudioClip clip;
        public string hash;
    }
}