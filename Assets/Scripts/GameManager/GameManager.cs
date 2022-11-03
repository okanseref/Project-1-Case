using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        public int N;
        private GridScaler gridScaler;
        private GridSearcher gridSearcher;
        private GridSimple gridSimple;
        private InputHandler inputHandler;
        public void Construct(GridScaler gridScaler, GridSearcher gridSearcher, GridSimple gridSimple, InputHandler inputHandler)
        {
            this.gridScaler = gridScaler;
            this.gridSearcher = gridSearcher;
            this.gridSimple = gridSimple;
            this.inputHandler = inputHandler;
        }
        void Start()
        {
            inputHandler.SetSelectEvent(BoxClicked);
            gridSimple.InitializeGrid(N);
            gridScaler.OrderGrids(gridSimple.grid, N);
        }
        private void BoxSelected(Box box)
        {

        }
        private void BoxClicked()
        {
            Box selectedBox = inputHandler.GetSelectedBox();
            selectedBox.SetTick(true);
            List<Box> boxesToTicked = gridSearcher.BreadthFirstSearch(gridSimple.grid, selectedBox);

            foreach (Box boxToTicked in boxesToTicked)
            {
                boxToTicked.SetTick(false);
            }
        }
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector2 cubeRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                RaycastHit2D cubeHit = Physics2D.Raycast(cubeRay, Vector2.zero);

                if (cubeHit.transform.tag.Equals("Box"))
                {
                    BoxSelected(cubeHit.transform.GetComponent<Box>());
                    Debug.Log("We hit " + cubeHit.collider.name);
                }
            }
        }
    }

}
