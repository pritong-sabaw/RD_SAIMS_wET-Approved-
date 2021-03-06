using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOf;

namespace UtilitiesLibrary
{
    public class UnitConverter
    {
        //------------------------------------------------------------------------------
        // <auto-generated>
        //     This code was generated by a tool.
        //     Runtime Version:4.0.30319.42000
        //
        //     Changes to this file may cause incorrect behavior and will be lost if
        //     the code is regenerated.
        // </auto-generated>
        //------------------------------------------------------------------------------

        public string ConvertUnit(double amount, string p_unit, string n_unit)
        {
            double qty = 0;

            if (p_unit == "Kg/s" && n_unit == "Kg/s" || string.IsNullOrEmpty(n_unit))
            {
                Mass def = new Mass().FromKilograms(amount);
                qty = def.ToKilograms();
            }
            else if (p_unit == "Mg/s" && n_unit == "Mg/s" || string.IsNullOrEmpty(n_unit))
            {
                Mass def = new Mass().FromMilligrams(amount);
                qty = def.ToMilligrams();
            }
            else if (p_unit == "G/s" && n_unit == "G/s" || string.IsNullOrEmpty(n_unit))
            {
                Mass def = new Mass().FromGrams(amount);
                qty = def.ToGrams();
            }
            else if (p_unit == "Kg/s" && n_unit == "Mg/s")
            {
                Mass def = new Mass().FromKilograms(amount);
                qty = def.ToMilligrams();
            }
            else if (p_unit == "Kg/s" && n_unit == "G/s")
            {
                Mass def = new Mass().FromKilograms(amount);
                qty = def.ToGrams();
            }
            else if (p_unit == "Mg/s" && n_unit == "Kg/s")
            {
                Mass def = new Mass().FromMilligrams(amount);
                qty = def.ToKilograms();
            }
            else if (p_unit == "Mg/s" && n_unit == "G/s")
            {
                Mass def = new Mass().FromMilligrams(amount);
                qty = def.ToGrams();
            }
            else if (p_unit == "G/s" && n_unit == "Mg/s")
            {
                Mass def = new Mass().FromGrams(amount);
                qty = def.ToMilligrams();
            }
            else if (p_unit == "G/s" && n_unit == "Kg/s")
            {
                Mass def = new Mass().FromGrams(amount);
                qty = def.ToKilograms();
            }
            return qty.ToString();
        }

    }
}
