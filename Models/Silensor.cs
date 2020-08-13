using SQLite;
using System;

namespace Shhh.Models
{
    public class Silensor
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { set; get; }

        public DateTime CreatedDate { set; get; }

        public double Latitude { set; get; }

        public double Longitude { set; get; }

        public string Remarks { set; get; }

        public bool Open { set; get; }

        [Ignore]
        public string CreatedOn
        {
            get
            {
                if (CreatedDate != null)
                    return CreatedDate.ToString("dd-MM-yy HH:ss");

                return string.Empty;
            }
        }
    }
}
