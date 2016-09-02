using UnityEngine;
using System.Collections;

public class HpGauge : MonoBehaviour 
{
    enum Easetype
    {
        easeInQuad, easeOutQuad, easeInOutQuad, easeInCubic, easeOutCubic, easeInOutCubic,
        easeInQuart, easeOutQuart, easeInOutQuart, easeInQuint, easeOutQuint, easeInOutQuint,
        easeInSine, easeOutSine, easeInOutSine, easeInExpo, easeOutExpo, easeInOutExpo,
        easeInCirc, easeOutCirc, easeInOutCirc, linear, spring,
        easeInBounce, easeOutBounce, easeInOutBounce, easeInBack, easeOutBack, easeInOutBack,
        easeInElastic, easeOutElastic, easeInOutElastic
    }
    [SerializeField]
    Easetype easetype = Easetype.easeOutQuad;

    [SerializeField]
    private float takeScalingTime = 1.5f;

    private float localScaleXMax;

    void Awake()
    {
        localScaleXMax = transform.localScale.x;
    }

    public void ShowAnimation(float hpPercentage)
    {
        //Debug.Log(hpPercentage);

        Vector3 newScale = new Vector3(localScaleXMax * hpPercentage, transform.lossyScale.y, transform.localScale.z);
        iTween.ScaleTo(this.gameObject, iTween.Hash(
                        "scale", newScale,
                        "Time", takeScalingTime,
                        "easeType", easetype.ToString()
        ));
    }
	
}
