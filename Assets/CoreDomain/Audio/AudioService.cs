using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace IpegamaGames
{
    public class AudioService : MonoBehaviour, IAudioService
    {
        [SerializeField] private AudioSource _masterAudioSource;
        [SerializeField] private AudioSource _FxAudioSource;
        [SerializeField] private AudioSource _MusicAudioSource;

        private readonly List<AudioClipsScriptableObject> _audioClipsScriptableObjects = new();
        private readonly Dictionary<AudioChannelType, AudioSource> _audioSourceByChannel = new();

        public void InitEntryPoint()
        {
            _audioSourceByChannel.Add(AudioChannelType.Master, _masterAudioSource);
            _audioSourceByChannel.Add(AudioChannelType.Fx, _FxAudioSource);
            _audioSourceByChannel.Add(AudioChannelType.Music, _MusicAudioSource);
        }
        public void AddAudioClips(AudioClipsScriptableObject audioClipsScriptableObject)
        {
            throw new System.NotImplementedException();
        }

        public void PlayAudio(AudioClipType audioClipType, AudioChannelType audioChannel, AudioPlayType audioPlayType = AudioPlayType.OneShot)
        {
            throw new System.NotImplementedException();
        }

        public Awaitable PlayAudioAsync(AudioClipType audioClipType, AudioChannelType audioChannel, CancellationTokenSource cancellationTokenSource, AudioPlayType audioPlayType = AudioPlayType.OneShot)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAudioClips(AudioClipsScriptableObject audioClipsScriptableObject)
        {
            throw new System.NotImplementedException();
        }

        public void StopAllAudio()
        {
            throw new System.NotImplementedException();
        }
    }
}
