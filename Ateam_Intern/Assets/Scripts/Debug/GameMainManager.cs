using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameMainManager : MonoBehaviour 
{
    [SerializeField]
    private GameObject CharactorPrefab;

    private List<CharactorData> charactorList = new List<CharactorData>();

    void Awake()
    {
        charactorList = JsonManager.Load<CharactorData>("SelectedCharactor.json") as List<CharactorData>;
    }

	// Use this for initialization
	void Start () 
    {
        foreach(CharactorData data in charactorList)
        {
            GameObject charactor = new GameObject();
            Charactor_Debug charactorData = charactor.AddComponent<Charactor_Debug>();

            charactor = (GameObject)Instantiate(CharactorPrefab);

        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
