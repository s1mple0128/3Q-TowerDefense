//=====================================================
// - FileName:      Tower.cs
// - Created:       Sth
// - CreateTime:      2021/01/04 10:34:39
// - Email:         438599338@qq.com
// - Description:   
// -  (C) Copyright 2008 - 2018,wegame ,Inc.
// -  All Rights Reserved.
//======================================================

namespace Script.Object
{
    public class Tower : MyObject {
    
        // Use this for initialization
        void Start ()
        {
            type = (int)ConstConfig.ObjectType.Tower;
            Defence = 1234;
        }
    
        // Update is called once per frame
        void Update () {
        
        }

        public void upgradeTower()
        {
        }
    }
}