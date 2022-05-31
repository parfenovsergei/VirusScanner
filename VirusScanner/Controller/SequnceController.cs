using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VirusScanner.Model;

namespace VirusScanner.Controller
{
    public  class SequnceController
    {
        public SequnceController()
        {

        }

        public void addSequnce(string sequnce)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                ByteSequnce byteSequnce = new ByteSequnce { HexSequnce = sequnce };
                db.ByteSequnces.Add(byteSequnce);
                db.SaveChanges();
            }
        }
        public string[] SetComboBox()
        {
            string[] sequncesStr;
            using (ApplicationContext db = new ApplicationContext())
            {
                var sequnces = db.ByteSequnces.ToList();
                sequncesStr = new string[sequnces.Count];
                for (int i = 0; i < sequncesStr.Length; i++)
                {
                    sequncesStr[i] = sequnces[i].HexSequnce;
                }
            }
            return sequncesStr;
        }

    }
}
