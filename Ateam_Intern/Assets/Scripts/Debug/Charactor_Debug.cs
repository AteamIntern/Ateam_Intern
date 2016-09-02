using System;
using UnityEngine;
using UnityEngine.UI;


public class Charactor_Debug : MonoBehaviour 
{

    [SerializeField]
    private float Hp;
    public float hp { get { return Hp;} private set { Hp = value; } }
    [SerializeField]
    private float Attack;
    public float  attack { get { return Attack;} private set { Attack = value; } }
    [SerializeField,TextAreaAttribute(4, 4)]
    private string SkillText;
    public string skillText{ get { return SkillText;} private set { SkillText = value; } }

    public string spriteName { get; private set; }

    void Awake()
    {
        spriteName = GetComponent<Image>().sprite.name;
        CharactorData charactorData = new CharactorData(this);
        CharactorData_Debug.AddData(charactorData);
    }

    public void Init(CharactorData charactorData)
    {
        this.hp = charactorData.hp;
        this.attack = charactorData.attack;
        this.skillText = charactorData.skillText;
        this.spriteName = charactorData.spriteName;
    }
	
}

[Serializable]
public class CharactorData
{
    [SerializeField]
    private float Hp;
    public float hp{ get { return Hp;} private set { Hp = value;}}
    [SerializeField]
    private float Attack;
    public float attack { get { return Attack; } private set { Attack = value; } }
    [SerializeField]
    private string SkillText;
    public string skillText { get { return SkillText; } private set { SkillText = value; } }
    [SerializeField]
    private string SpriteName;
    public string spriteName { get { return SpriteName; } private set { SpriteName = value; } }

    public CharactorData(Charactor_Debug charactorData)
    {
        this.Hp = charactorData.hp;
        this.Attack = charactorData.attack;
        this.SkillText = charactorData.skillText;
        this.SpriteName = charactorData.spriteName;
    }
}