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
    /// <summary>
    /// 塔基，负责接受外部操作信息
    /// </summary>
    public class TowerBase : MonoBehaviour
    {
        public GameObject towerObj = null;

        [SerializeField]
        private GameObject curTarget = null;

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