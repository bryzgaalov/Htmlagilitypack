using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace parthing_agality_pack
{
   public class Model
    {

        public string Surname { get; set; }
        public string Name { get; set; }
        public string Otch { get; set; }
        public string Birthday { get; set; }
        public string Organ { get; set; }
        public string Organ_tel { get; set; }

        public Model()
        {
            Surname = "";
            Name = "";
            Otch = "";
            Birthday = "";
            Organ = "";
            Organ_tel = "";

        }
        public Model(string Surname,string Name,string Otch,string Birthday,string Organ,string ORgan_tel)
        {
            this.Surname = Surname;
            this.Name = Name;
            this.Otch = Otch;
            this.Birthday = Birthday;
            this.Organ = Organ;
            this.Organ_tel = Organ_tel;
        }



    }
}

//if (doc.DocumentNode != null)
//                                        {
//                                            var datas = doc.DocumentNode.SelectNodes("/html/body/table[3]/tbody/tr[2]/td/span/div/div[6]/a[2]");
//                                            if (datas != null )
//                                            {
//                                                Console.WriteLine("Данные дошли до сюда");

//                                                foreach (var data in datas)
//                                                {
//                                                    var tbl = data.SelectNodes(".//li//div");
//                                                    if (tbl != null && tbl.Count != 0)
//                                                    {
//                                                        Console.WriteLine("Данные дошли до сюда222");
//                                                        foreach (var cells in tbl)
//                                                        {
//                                                            Console.WriteLine(cells.InnerText);
//                                                        }
//                                                    }
//                                                }
//                                            }
//                                            else
//                                            {
//                                                Console.WriteLine("Данные пусты!");
//                                            }
//                                        }
//                                        else
//                                        {
//                                            Console.WriteLine("Document node null!");
//                                        }
