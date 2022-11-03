using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        public int N;
        private GridScaler _gridScaler;
        private GridSearcher _gridSearcher;
        private GridSimple _gridSimple;
        private InputHandler _inputHandler;
        public void Construct(GridScaler gridScaler, GridSearcher gridSearcher, GridSimple gridSimple, InputHandler inputHandler)
        {
            _gridScaler = gridScaler;
            _gridSearcher = gridSearcher;
            _gridSimple = gridSimple;
            _inputHandler = inputHandler;
        }
        void Start()
        {
            _inputHandler.SetSelectEvent(BoxClicked);
            _gridSimple.InitializeGrid(N);
            _gridScaler.OrderGrids(_gridSimple.Grid, N);
        }
        public void ResetGrid(int newN)
        {
            N = newN;
            _gridSimple.RemoveGrid();
            _gridSimple.InitializeGrid(N);
            _gridScaler.OrderGrids(_gridSimple.Grid, N);
        }
        private void BoxClicked()
        {
            Box selectedBox = _inputHandler.GetSelectedBox();
            selectedBox.SetTick(true);
            List<Box> boxesToTicked = _gridSearcher.BreadthFirstSearch(_gridSimple.Grid, selectedBox);

            foreach (Box boxToTicked in boxesToTicked)
            {
                boxToTicked.SetTick(false);
            }
        }
    }

}
