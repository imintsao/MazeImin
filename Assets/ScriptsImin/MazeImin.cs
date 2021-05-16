using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeImin : MonoBehaviour
{

    public int sizeX, sizeZ;

    public MazeCellImin cellPrefab;

    private MazeCellImin[,] cells;

    public float generationStepDelay;

    public IEnumerator Generate()
    {

        WaitForSeconds delay = new WaitForSeconds(generationStepDelay);
        cells = new MazeCellImin[sizeX, sizeZ];
        for (int x = 0; x < sizeX; x++)
        {
            for (int z = 0; z < sizeZ; z++)
            {
                yield return delay;
                CreateCell(x, z);
            }
        }
    }

    private void CreateCell(int x, int z)
    {
        MazeCellImin newCell = Instantiate(cellPrefab) as MazeCellImin;
        cells[x, z] = newCell;
        newCell.name = "Maze Cell " + x + ", " + z;
        newCell.transform.parent = transform;
        newCell.transform.localPosition = new Vector3(x - sizeX * 0.5f + 0.5f, 0f, z - sizeZ * 0.5f + 0.5f);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
