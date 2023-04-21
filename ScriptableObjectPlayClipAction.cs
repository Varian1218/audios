using UnityEngine;

namespace Audios
{
    [CreateAssetMenu(fileName = "Play Clip Action", menuName = "Audios/Play Clip Action", order = 1)]
    public class ScriptableObjectPlayClipAction : ScriptableObject, IPlayClipAction
    {
        private IPlayClipAction _impl;

        public IPlayClipAction Impl
        {
            set => _impl = value;
        }

        public void Invoke(string hash)
        {
            _impl.Invoke(hash);
        }
    }
}