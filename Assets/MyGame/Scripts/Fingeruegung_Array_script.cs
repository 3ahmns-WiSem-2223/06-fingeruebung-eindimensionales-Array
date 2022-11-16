using UnityEngine;

public class Fingeruegung_Array_script : MonoBehaviour
{
    public int[] array;
    public int[] array1 = new int[4];
    public int[] array2 = new int[4] { 21, 22, 23, 24 };
    public int[] array3 = new int[7] { 31, 32, 33, 34, 35, 36, 37 };
    public string[] array4 = new string[10];
    public GameObject[] arrayColoredImagesRed; 
    void Start()
    {
        for (int i = 0; i < array4.Length; i++)
        {
            array4[i] = "array4";
        }

       
        
        arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");
        

       
    }
    void Update()
    {
        
    }
}
