using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DataForms;

public class DataManager : ManagerBase
{
    private List<DataForm> gameData = new List<DataForm>();

    public override void Init()
    {
        gameData = Load<DataObject, DataForm>();
    }

    private List<T> Load<Loader, T>() where Loader : IDataForm<T>
    {
        TextAsset asset = Resources.Load<TextAsset>("DataExample");
        Loader form = JsonUtility.FromJson<Loader>(asset.text);
        return form.GetList();
    }

    public List<DataForm> GetExampleData()
    {
        return gameData;
    }
}
