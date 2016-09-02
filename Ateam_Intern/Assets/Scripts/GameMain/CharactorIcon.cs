using UnityEngine;
using UniRx;
using UniRx.Triggers;
using UnityEngine.UI;

public class CharactorIcon : MonoBehaviour
{
    [SerializeField]
    private GameObject charactorInfoPrefab;

    [SerializeField]
    private Charactor_Debug charactorInfo;
    public Charactor_Debug _charactorInfo { get { return charactorInfo;} private set { charactorInfo = value;}}

    void Reset()
    {

    }

    void Start()
    {
        string spritePath = "Textures/" + charactorInfo.spriteName;
        GetComponent<Image>().sprite = Resources.Load<Sprite>(spritePath);
        transform.GetChild(0).transform.GetChild(0).GetComponent<Text>().text = charactorInfo.skillText;


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
