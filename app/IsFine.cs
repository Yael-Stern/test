using App.models;
using App.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace App
{
    internal class IsFine 

    {
        public int reportDay {  get; set; }
        public List<string[]> getRows { get; set; }
        public List<string> Fines { get; set; }
        public List<string> Flagged { get; set; }
        public List<string> Errors { get; set; }
        public IsFine(int reportDay, List<string[]> getRows)
        {
            reportDay = reportDay;
            getRows = getRows;
        }
        public void totalFine( string[] lines)
        {
            int total = 0;


            //for(int i = 0; i < lines.Length; i++)
            //{
            //    if (i[5] - i[4])
            //}
                
           
        }

    }
}
