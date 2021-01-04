using Script.Factory;
using Script.Object;
using UnityEngine;

namespace Script.Tower
{
    public static class TowerManager
    {
        public static bool AddSpecTowerToBase(TowerBase towerBase, TowerType type)
        {
            var tempVector3 = towerBase.transform.position;
            tempVector3.y += towerBase.transform.GetComponent<BoxCollider>().size.y / 2;
            var tower = ObjectFactory.CreateObject(ObjectType.Tower, ConstConfig.PrefabPath, tempVector3);
            if (!tower)
            {
                Logger.Log("创建塔体失败！！！");
                return false;
            }
            tower.transform.position = new Vector3(tempVector3.x,
                tempVector3.y + tower.GetComponent<BoxCollider>().size.y - 0.2f,
                tempVector3.z);
            towerBase.AddTower(tower.GetComponent<Tower>());
            return true;
        }

        public static GameObject GetNearestObjectByRadius(float radius)
        {
            return null;
        }
    }
}