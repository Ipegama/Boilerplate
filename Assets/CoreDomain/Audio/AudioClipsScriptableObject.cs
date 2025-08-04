using System.Collections.Generic;
using UnityEngine;

namespace IpegamaGames
{
    public abstract class AudioClipsScriptableObject : ScriptableObject
    {
        public Dictionary<AudioClipType, AudioClip> AudioClips;
    }
}
