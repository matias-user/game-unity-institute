using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMainAnimations : MonoBehaviour
{
    private string layerIdle = "Idle Layer";
    private string layerWalk = "Walk Layer";
    private CharMovement _charMovement;
    private Animator _animator;
    void Start()
    {

    }
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _charMovement = GetComponent<CharMovement>();
    }
    void Update()
    {
        UpdateLayer();
        if ( _charMovement.isMoving ) 
        {
            _animator.SetFloat("X", _charMovement.MoveDirection.x);
            _animator.SetFloat("Y", _charMovement.MoveDirection.y);

        }


    }
    public void ActivateLayer(string layerName)
    {
        //Desactivar todas las capas
        for(int i = 0; i < _animator.layerCount; i++)
        {
            _animator.SetLayerWeight(i, 0);
        }
        _animator.SetLayerWeight(_animator.GetLayerIndex(layerName), 1);
    }
    private void UpdateLayer()
    {
        if(_charMovement.isMoving )
        {
            ActivateLayer(layerWalk);
        }
        else
        {
            ActivateLayer(layerIdle);

        }
    }
}
