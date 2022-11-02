using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Services
{
    public class GameManager : MonoBehaviour
    {
        public int N;
        private GridScaler gridScaler;
        private GridSearcher gridSearcher;
        public void Construct(GridScaler gridScaler, GridSearcher gridSearcher)
        {
            this.gridScaler = gridScaler;
            this.gridSearcher = gridSearcher;
        }
        void Start()
        {

        }

    }

}
