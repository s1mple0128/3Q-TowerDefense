//=====================================================
// - FileName:      myObject.cs
// - Created:       Sth
// - CreateTime:      2021/01/04 09:57:01
// - Email:         438599338@qq.com
// - Description:   
// -  (C) Copyright 2008 - 2018,wegame ,Inc.
// -  All Rights Reserved.
//======================================================

using UnityEngine;

namespace Script.Object
{
    public enum ObjectType
    {
        Tower, //塔
        Monster, //怪物
        Hero, //暂定有英雄
    };

    public class BaseObject : MonoBehaviour
    {
        public ObjectType type;
        public int Attack { get; set; }

        public int Defence { get; set; }

        public int Hp { get; set; }
    }
}