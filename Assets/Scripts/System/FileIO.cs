using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

namespace EMSYS.TowerDefence.System
{
    public class FileIO : MonoBehaviour
    {
        private string path = "{0}/save1.sav";
        FileInfo info;
        FileStream stream;
        public void LoadFile()
        {

        }
        public void SaveFile()
        {
            string destination = Application.persistentDataPath + "/save.dat";
            FileStream file;

            if (File.Exists(destination)) file = File.OpenWrite(destination);
            else file = File.Create(destination);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file, "");
            file.Close();
        }
        private void Awake()
        {
            path = string.Format(path, Application.persistentDataPath);
            if (File.Exists(path))
            {
                
            }

        }
        private void Start()
        {

        }
        void Update()
        {

        }
    }

}
