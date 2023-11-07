using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class DataForms
{
    public interface IDataForm<T>
    {
        public List<T> GetList();
    }

    [System.Serializable]
    public class DataForm
    {
        public int id;
        public string intro;
    }

    [System.Serializable]
    public class DataObject : IDataForm<DataForm>
    {
        public List<DataForm> list = new List<DataForm>();

        public List<DataForm> GetList()
        {
            return list;
        }
    }
}
