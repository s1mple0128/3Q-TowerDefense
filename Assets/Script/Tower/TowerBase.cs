//=====================================================
// - FileName:      TowerBase.cs
// - Created:       Sth
// - CreateTime:      2021/01/04 14:49:45
// - Email:         438599338@qq.com
// - Description:   
// -  (C) Copyright 2008 - 2018,wegame ,Inc.
// -  All Rights Reserved.
//======================================================

using Script.Factory;
using Script.Object;
using UnityEngine;

namespace Script.Tower
{
    public class TowerBase : MonoBehaviour
    {
        public GameObject towerObj = null;

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
        }

        private void OnMouseDown()
        {
            Debug.Log("点击塔体");
            TowerManager.AddSpecTowerToBase(this, TowerType.Normal);
        }

        public void AddTower(Tower tTower)
        {
            if (towerObj)
            {
                Logger.Log("塔基已经存在对应塔体");
                return;
            }
            towerObj = tTower.gameObject;
        }
    }
}