using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;
using System.IO;

public class WriteTextFile : MonoBehaviour
{
    public string name;
    string path;
    
    void Start()
    {
        path = "Assets/Resources/Results/"+name+".txt";
    }

    public void Write(string data)
    {
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(data);
        writer.Close();           
     }

        
}
