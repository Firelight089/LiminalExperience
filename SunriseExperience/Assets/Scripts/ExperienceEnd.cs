using System.Collections;
using Liminal.SDK.Core;
using Liminal.SDK.VR.Avatars;
using UnityEngine;

public class ExperienceEnd : MonoBehaviour
{
    public float Duration;

    public IEnumerator Start()
    {
        yield return new WaitForSeconds(Duration);
        StartCoroutine(FadeAudio(4));
        VRAvatar.Active.ScreenFader.FadeToBlack(3f);
        yield return VRAvatar.Active.ScreenFader.WaitUntilFadeComplete();
        yield return new WaitForSeconds(1);
        ExperienceApp.End(true);
    }

    public IEnumerator FadeAudio(float duration)
    {
        var time = duration;
        while (AudioListener.volume > 0)
        {
            AudioListener.volume = Mathf.Lerp(1, 0, 1 - time/duration);
            time -= Time.deltaTime;
            yield return null;
        }

        AudioListener.volume = 0;
    }
}
