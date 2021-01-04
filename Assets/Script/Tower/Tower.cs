//=====================================================
// - FileName:      Tower.cs
// - Created:       Sth
// - CreateTime:      2021/01/04 10:34:39
// - Email:         438599338@qq.com
// - Description:   
// -  (C) Copyright 2008 - 2018,wegame ,Inc.
// -  All Rights Reserved.
//======================================================

using Script.Object;

namespace Script.Tower
{
    public enum TowerType
    {
        Normal, // 普通防御塔
    }

    public class Tower : BaseObject
    {
        public TowerType towerType = TowerType.Normal;
        // Use this for initialization
        private void Start()
        {
            type = ObjectType.Tower;
        }

        // Update is called once per frame
        void Update()
        {
        }

        public void UpgradeTower()
        {
        }
    }
}