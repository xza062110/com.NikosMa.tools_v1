using UnityEngine;

namespace NikosMa.Tools
{
    /// <summary>
    /// 播放聲音管理器
    /// </summary>
    public class PlaySoundManager : MonoBehaviour
    {
        /// <summary>
        /// 播放音效
        /// </summary>
        /// <param name="clip"> 音效 </param>
        private void PlaySound(AudioClip clip)
        { 
            SoundManager.instance.PlaySound(clip);
        }
    }
}

