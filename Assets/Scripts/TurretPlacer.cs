using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TurretPlacer : MonoBehaviour { 

    [SerializeField] private Turrete[] _turretes;
    [SerializeField] private RectTransform _turretsBtnRoot;
    [SerializeField] private TurretButton _turretButton;
    [SerializeField] private Transform _target;
    public static TurretPlacer instance;
    public GameObject gameOverPanel;


    private void Start()
    {
        InitTurretUI();
    }

    private void InitTurretUI()
    {
        foreach (var turret in _turretes)
        {
            var btn = Instantiate(_turretButton, _turretsBtnRoot);
            btn.Init(turret, _target);
        }
    }

}