using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class AnimatorController {
    public AnimatorController(Animator animator_)
    {
        this.animator = animator_;
    }
    Animator animator;
    Dictionary<int, StateInfo> stateInfos = new Dictionary<int, StateInfo>();
    int curNameHash = -1;
    struct StateInfo
    {
        public int fullPathName;
        public Action<AnimatorStateInfo> onStart;
        public Action<AnimatorStateInfo> onPlaying;
        public Action<AnimatorStateInfo> onFinish;
    }

    public void Register(string layerName,string stateName, Action<AnimatorStateInfo> onStart, Action<AnimatorStateInfo> onPlaying, Action<AnimatorStateInfo> onFinish )
    {
        RegisterWithLayer(layerName, stateName, onStart, onPlaying, onFinish);
    }
	void RegisterWithLayer(string layerName_, string stateName_, Action<AnimatorStateInfo> onStart_, Action<AnimatorStateInfo> onPlaying_, Action<AnimatorStateInfo> onFinish_)
    {
        StateInfo stateInfo = new StateInfo()
        {
            fullPathName = Animator.StringToHash(string.Format("{0}.{1}", layerName_, stateName_)),
            onStart = onStart_,
            onPlaying = onPlaying_,
            onFinish = onFinish_
        };
        stateInfos.Add(stateInfo.fullPathName, stateInfo);
    }
    AnimatorStateInfo _aniStateInfo;
    int _nameHash;
    StateInfo _stateInfo;
	public void Update () {
        if (stateInfos.Count == 0)
            return;
        _aniStateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if(stateInfos.ContainsKey(_aniStateInfo.fullPathHash))
        {
            _stateInfo = stateInfos[_aniStateInfo.fullPathHash];
            if (_nameHash != _stateInfo.fullPathName)
            {
                if(_nameHash == -1)                     //动画开始
                {
                    if (_stateInfo.onStart != null)
                        _stateInfo.onStart(_aniStateInfo);
                    _nameHash = _aniStateInfo.fullPathHash;
                }
                else//动画结束
                {
                    if (_stateInfo.onFinish != null)
                        _stateInfo.onFinish(_aniStateInfo);
                    _nameHash = -1;
                }

            }else//动画播放中
            {
                if (_stateInfo.onPlaying != null)
                    _stateInfo.onPlaying(_aniStateInfo);
            }
        }
	}
}
