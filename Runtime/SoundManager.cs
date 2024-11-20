using UnityEngine;

namespace NikosMa.Tools
{
    /// <summary>
    /// 音效管理器
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public class SoundManager : MonoBehaviour
    {
        private static SoundManager _instance;
        public static SoundManager instance
        {
            get
            {
                if (_instance == null) _instance = FindObjectOfType<SoundManager>();
                return _instance;
            }
        }

        private AudioSource aud;

        private void Awake()
        {
            aud = GetComponent<AudioSource>();
        }

        /// <summary>
        /// 播放音效
        /// </summary>
        /// <param name="sound"> 音效 </param>
        /// <param name="min"> 最小音量 </param>
        /// <param name="max"> 最大音量 </param>
        public void PlaySound(AudioClip sound, float min = 0.8f, float max = 1.2f)
        {
            float volume = Random.Range(min, max);
            aud.PlayOneShot(sound, volume);
        }


    }
}

