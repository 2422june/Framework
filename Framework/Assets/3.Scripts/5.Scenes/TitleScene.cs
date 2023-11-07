using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScene : SceneBase
{
    public override void Init()
    {
        _type = Define.Scene.Title;
        _name = "Title";
        _scene = gameObject;

        InitUI();
        InitEvent();
    }

    protected override void InitUI()
    {
    }

    private void InitEvent()
    {
        Managers.Event.AddLeaveButton(LeaveButton);
    }

    public override void StartLoad()
    {
        OnLoad();
    }

    protected override void OnLoad()
    {
        //Managers.Audio.PlayBGM();
    }

    private void LeaveButton()
    {
#if UNITY_EDITOR
        Application.Quit();
#endif
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
