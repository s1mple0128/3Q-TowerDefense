using UnityEngine;

namespace Script.Tower
{
    /// <summary>
    /// 塔战斗相关接口
    /// </summary>
    public interface ITowerFightInterface
    {
        void SeekObject();

        void TryAttackObject();
    }
}