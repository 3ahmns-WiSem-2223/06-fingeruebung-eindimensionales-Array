using UnityEngine;

public class Fingeruegung_Array_script : MonoBehaviour
{
    [SerializeField]
    int[] array;
    [SerializeField]
    int[] array1 = new int[4];
    [SerializeField]
    int[] array2 = new int[4] { 21, 22, 23, 24 };
    [SerializeField]
    int[] array3 = new int[7] { 31, 32, 33, 34, 35, 36, 37 };
    [SerializeField]
    string[] array4 = new string[10];
    [SerializeField]
    GameObject[] arrayColoredImagesRed;
    [SerializeField]
    int[] array5 = new int[25];
    [SerializeField]
    int[] array6 = new int[250];
    [SerializeField]
    int[] array7 = new int[250];
    int b = 1;
    [SerializeField]
    string[] array8 = new string[100];
    [SerializeField]
    int[] array9 = new int[1000];
    [SerializeField]
    int[] array11 = new int[1000];
 

    int a = 20;
    void Start()
    {
        for (int i = 0; i < array4.Length; i++)
        {
            array4[i] = "array4";
        }
        arrayColoredImagesRed = GameObject.FindGameObjectsWithTag("RedImage");

        for (int i = 0; i < array5.Length; i++)
        {
            a = a + 2;
            array5[i] = a;
        }

        for (int i = 0; i < array6.Length; i++)
        {
            
            array6[i] = i * 2; 
        }

        for (int i = 0; i < array7.Length; i++)
        {
            array7[i] = b;
            b = b + 2;
        }

        for (int i = 0; i < array8.Length; i++)
        {
            array8[i] = "a";
            i = i + 2;
        }

        for (int d = 0; d < array8.Length; d++)
        {
            array8[d] = "b";
            d = d * 2;
        }

        for (int i = 0; i < array9.Length; i++)
        {
            array9[i] = Random.Range(0, 1000);
            Debug.Log(array9[i]);
        }

        System.Array.Sort(array9);
        for (int i = 0; i < array9.Length; i++)
        {
            Debug.Log(array9[i]);
        }

        for (int i = 0; i < array11.Length; i++)
        {
            array11[i] = UnityEngine.Random.Range(0, 100000);
        }

        System.Array.Sort(array11);

        Debug.Log(array11[0]);
        Debug.Log(array11[array11.Length - 1]);



        Debug.Log(array1[0]);
        Debug.Log(array2[0]);
        Debug.Log(array3[0]);
        Debug.Log(array4[0]);
        Debug.Log(arrayColoredImagesRed[0]);

        Debug.Log(array1[array1.Length - 1]);
        Debug.Log(array2[array2.Length - 1]);
        Debug.Log(array3[array3.Length - 1]);
        Debug.Log(array4[array4.Length - 1]);
        Debug.Log(arrayColoredImagesRed[arrayColoredImagesRed.Length - 1]);

        for (int i = 0; i < array3.Length; i++)
        {
            Debug.Log(array3[i]);
        }

        AlleWerte();

        array1[3] = 3;
        Debug.Log(array1[3]);

        array2[2] = 203;
        Debug.Log(array2[2]);

        array3[5] = 333;
        Debug.Log(array3[5]);

        array4[2] = "heute";
        Debug.Log(array4[2]);

        arrayColoredImagesRed[2].GetComponent<SpriteRenderer>().color = Color.green;

        
        void AlleWerte()
        {
            Debug.Log(array2[0] + " " + array2[1] + " " + array2[2] + " " + array2[3]);
        }

    }
}
