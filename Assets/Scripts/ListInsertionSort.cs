using System.Collections.Generic;
using UnityEngine;

public class ListInsertionSort : MonoBehaviour
{
    List<int> numberList = new List<int> { 7, 1, 9, 6, 0 };

    string ListToString(List<int> list)
    {
        return string.Join(", ", list);
    }

    void Start()
    {
        Debug.Log("Original List: " + ListToString(numberList));

        InsertionSort(numberList);

        Debug.Log("Sorted List: " + ListToString(numberList));
    }

    void InsertionSort(List<int> list)
    {
        for (int i = 1; i < list.Count; i++)
        {
            int key = list[i];
            int j = i - 1;

            while (j >= 0 && list[j] > key)
            {
                list[j + 1] = list[j];
                j--;
            }

            list[j + 1] = key;
        }
    }
}


