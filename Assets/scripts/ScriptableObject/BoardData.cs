using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu]
public class BoardData : ScriptableObject
{
    [System.Serializable]
    public class SearchingWord
    {
        public string word ;
    }
    [System.Serializable]
    public class BoardRow 
    {
        public int Size ;
        public string[] Row ;
        public BoardRow(){}
        public BoardRow(int size)
        {
            CreateRow(size);
        }
        public void CreateRow(int size)
        {
            Size = size ;
            Row = new string[Size];
            ClearRow();
        }
        public void ClearRow()
        {
            for (int i=0 ; i< Size ; i++)
            {
                Row[i] =" ";
            }
        }
    }
    public void ClearWithEmptyString()
    {
        for ( int i =0 ;i< columns ; i++)
        { 
            Board[i].ClearRow();
        }
    }
    
    public float timeInSeconds ;
    public int columns = 0 ;
    public int Rows = 0 ;
        public BoardRow[] Board ;
        public List<SearchingWord> SearchWords = new List<SearchingWord>();
    public void CreateNewBoard()
    {
        Board = new BoardRow[columns]; 
        for ( int i=0 ; i<columns ; i++)
        {
            Board[i] = new BoardRow(Rows);
        }
    }

}
