using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    static class Materialsdoc
    {
        public static List<Materials> materials = new List<Materials>();
        public static void AddMaterials(Materials new_materials)
        {   
            
            if (materials.Count == 0)
            {
                new_materials.ID = 1;
                materials.Add(new_materials);
            }
            else
            {
                int counter = 0;
                for (int i = 0; i < materials.Count; i++)
                {
                    if (materials[i].Factory == new_materials.Factory)
                    {
                        materials[i].Leftovers_start += new_materials.Leftovers_start;
                        materials[i].Received += new_materials.Received;
                        materials[i].Issued += new_materials.Issued;
                        materials[i].Leftovers_end = new_materials.Leftovers_start + new_materials.Received - new_materials.Issued;
                    }
                    else
                    {
                        counter++;
                        if (counter == materials.Count)
                        {
                            new_materials.ID = ++counter;
                           materials.Add(new_materials);
                            break;
                        }

                    }

                }
            }

        }

    }
}
