using UnityEngine;
using System.Collections;

public class CharactorSelect_Debug : MonoBehaviour 
{
    public void Save()
    {
        var list = CharactorData_Debug.GetList();

        JsonManager.Save(new Serialization<CharactorData>(list), "SelectedCharactor.json");
    }
}
