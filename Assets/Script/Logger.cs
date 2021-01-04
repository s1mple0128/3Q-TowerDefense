using UnityEngine;

namespace Script
{
    public static class Logger
    {
        public static void Log(string content, int msgLevel = 1)
        {
            Debug.Log(content);
        }
    }
}