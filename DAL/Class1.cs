using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DAL
{
    public class Class1
    {


        private void loadEntries_Click(OpenFileDialog entriesFileOpen)
        {
            string line;
            
                StreamReader file = new StreamReader(entriesFileOpen.FileName);

                while ((line = file.ReadLine()) != null)
                {
                    List<string> realEstateParameters = line.Split('\t').ToList();
                    RealEstateInterface buffer = new RealEstateModel(realEstateParameters);
                    this.addInternalRealStorage(buffer);
                    this.addToDataGridReal(buffer);
                }


            }
        }
