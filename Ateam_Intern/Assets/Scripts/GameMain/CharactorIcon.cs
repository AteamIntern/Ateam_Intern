using UnityEngine;
using System.Collections;
using UniRx;
using UniRx.Triggers;
using UnityEngine.UI;

public class CharactorIcon : MonoBehaviour 
{
    [SerializeField]
    private GameObject charactorInfoPrefab;

    [SerializeField]
    private Charactor_Debug charactorInfo;
    public Charactor_Debug _charactorInfo { get { return charactorInfo;} set { charactorInfo = value;}}

    void Start()
    {
        GetComponent<Image>().sprite = charactorInfo.sprite;
        transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = charactorInfo.text;


        this.UpdateAsObservable()
            .Select(_ => GetComponent<ButtonEx>().IsOn)
            .DistinctUntilChanged()
            .Subscribe(isOn => ChangeCharactorInfoView(isOn));
    }

    private void ChangeCharactorInfoView(bool isOn)
    {
        charactorInfoPrefab.SetActive(isOn);
    }
	
}
