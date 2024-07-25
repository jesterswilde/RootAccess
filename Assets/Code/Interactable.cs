#pragma warning disable 0649
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Sirenix.Utilities;

public class Interactable : MonoBehaviour
{
    [SerializeField]
    Detector _playerDetector;
    [SerializeField]
    float _highlightSpeed = 0.5f;
    [SerializeField]
    Color _highlightColor = Color.red;
    [SerializeField]
    float _blendAmount = 0.5f;
    [SerializeField]
    float _lerp = 0;
    [SerializeField]
    bool _playerIsNear = false;
    public bool PlayerIsNear => _playerIsNear;
    [SerializeField]
    bool canBeDeactivated = false;

    List<Renderer> _rends;
    List<Color> _baseColors;
    List<Color> _blendColors;
    Action _interact;
    bool _isDeactivated = false;

    public void Interact(){
        _interact();
        if(canBeDeactivated)
            _isDeactivated = true;
    }
    void PlayerEnter()
    {
        if (_isDeactivated)
            return;
        _playerIsNear = true;
    }
    void PlayerExit()
    {
        if (_isDeactivated)
            return;
        _playerIsNear = false;
    }
    public void Target(){
        for(int i = 0; i < _rends.Count; i++){
            var rend = _rends[i];
            Material[] mats = new Material[rend.materials.Length + 1];
            for(int j = 0; j < rend.materials.Length; j++){
                mats[j] = rend.materials[j];
            }
            mats[mats.Length - 1] = GameManager.OutlineMaterial;
            rend.materials = mats;
        }
    }
    public void Untarget(){
        for(int i = 0; i < _rends.Count; i++){
            var rend = _rends[i];
            Material[] mats = new Material[rend.materials.Length - 1];
            for(int j = 0; j < mats.Length; j++){
                mats[j] = rend.materials[j];
            }
            rend.materials = mats;
        }
    }

    private void Update()
    {
        if (_isDeactivated)
        {
            if(_lerp > 0)
            {
                _lerp -= Time.deltaTime * (1 / _highlightSpeed);
                _lerp = MathF.Max(0, _lerp);
                _rends.ForEach((r, i) => r.material.color = Color.Lerp(_baseColors[i], _blendColors[i], _lerp));
            }else
            {
                Destroy(this);
            }
            return;
        }
        if(_playerIsNear && _lerp < 1)
        {
            _lerp += Time.deltaTime * (1 / _highlightSpeed);
            _lerp = MathF.Min(1, _lerp);
            _rends.ForEach((r, i) => r.material.color = Color.Lerp(_baseColors[i], _blendColors[i], _lerp));
        }
        if(!_playerIsNear && _lerp > 0)
        {
            _lerp -= Time.deltaTime * (1 / _highlightSpeed);
            _lerp = MathF.Max(0, _lerp);
            _rends.ForEach((r, i) => r.material.color = Color.Lerp(_baseColors[i], _blendColors[i], _lerp));
        }
    }

    private void Awake()
    {
        _rends = GetComponentsInChildren<Renderer>().ToList();
        _baseColors = _rends.Select(r => r.material.color).ToList();
        _blendColors = _baseColors.Select(c => Color.Lerp(c, _highlightColor, _blendAmount)).ToList();
        var inter = (GetComponents<Component>().First(c => c is IInteractable) as IInteractable);
            //??  throw new Exception($"Need to attach an IInteracbtable component to game object {name}");
        _interact = inter.GotInteracted;
        if(_playerDetector == null)
            _playerDetector = GetComponentInChildren<Detector>();
        if(_playerDetector == null)
            Debug.LogWarning($"No player detector attached to {name}");
        _playerDetector.OnBlocked += PlayerEnter;
        _playerDetector.OnUnblocked += PlayerExit;
    }
}

