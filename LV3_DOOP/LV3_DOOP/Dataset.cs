using System;
using System.Collections.Generic;
using System.Text;

namespace LV3_DOOP
{
    class Dataset : Prototype
    {
        private List<List<string>> data; //list of lists of strings
        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
            return
           new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
            this.data = null;
        }
        public Prototype Clone()
        {
            Dataset copy = new Dataset();
            foreach(List<string> row in this.data)
            {
                List<string> rowCopy = new List<string>(row);
                copy.data.Add(rowCopy);
            }
            return copy;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach(List<string> row in this.data)
            {
                builder
                    .Append(string.Join(" ", row))
                    .Append("\n");
            }
            return builder.ToString();
        }
    }
}
