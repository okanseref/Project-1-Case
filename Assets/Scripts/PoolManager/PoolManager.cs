using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class PoolManager : MonoBehaviour
    {
        public static PoolManager instance;
        public ObjectPool boxPool;

        private void Awake()
        {
            if (PoolManager.instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
