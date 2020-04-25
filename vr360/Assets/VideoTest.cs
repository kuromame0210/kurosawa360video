using UnityEngine;
using UnityEngine.Video;

public class VideoTest : MonoBehaviour
{
    VideoPlayer videoPlayer;
    [SerializeField] Material video_M; //Video再生用マテリアル
    [SerializeField] Material default_M; //通常シーンのskymaterial
    [SerializeField] VideoClip videoClip;

    void Start()
    {
        var vp = GetComponent<VideoPlayer>();
        if (vp != null) videoPlayer = vp;

        RenderSettings.skybox = default_M;
    }

    void Update()
    {
        //Pで動画再生
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlayVideo(videoClip);
        }
    }

    void PlayVideo(VideoClip clip)
    {
        //Window>Rendering>Light settingのsky materialを入れ替える
        RenderSettings.skybox = video_M;
        videoPlayer.clip = clip;
    }
}