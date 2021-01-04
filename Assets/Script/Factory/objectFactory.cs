using System;
using Script.Object;
using UnityEngine;

namespace Script.Factory
{
    public class ObjectFactory : MonoBehaviour
    {
        public static GameObject CreateObject(Enum type, string prefabPath, Vector3 pos = new Vector3(),
            Quaternion rotate = new Quaternion())
        {
            GameObject tempInstance = null;
            switch (type)
            {
                case ObjectType.Tower:
                    Debug.Log("创建塔");
                    tempInstance = (GameObject) Instantiate(Resources.Load(prefabPath), pos, rotate);
                    break;
                case ObjectType.Monster:
                    Debug.Log("创建怪物");
                    break;
                case ObjectType.Hero:
                    Debug.Log("创建子弹");
                    break;
                default:
                    break;
            }

            return tempInstance;
        }
    }
}