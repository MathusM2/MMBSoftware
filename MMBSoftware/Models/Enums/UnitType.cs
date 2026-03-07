using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBSoftware.Models.Enums
{
    public enum UnitType
    {
        [Display(Name ="Unidade")]
        Unit = 1,
        [Display(Name ="Pacote")]
        Package = 2,
        [Display(Name ="Caixa")]
        Box = 3
    }
    public static class ToUnitTypeExtensions 
    {
        public static UnitType StringToUnitType(string unitType)
        {
            switch (unitType)
            {
                case "Unidade":
                    return UnitType.Unit;
                case "Pacote":
                    return UnitType.Package;
                case "Caixa":
                    return UnitType.Box;
                default:
                    throw new ArgumentException("Invalid unit type string");
            };
        }

        public static UnitType IntToUnitType(int unitType)
        {
            switch (unitType)
            {
                case 1:
                    return UnitType.Unit;
                case 2:
                    return UnitType.Package;
                case 3:
                    return UnitType.Box;
                default:
                    throw new ArgumentException("Invalid unit type integer");
            };
        }
    }

    public static class UnitTypeToStringExtensions 
    {
        public static string ToString(UnitType unitType)
        {
            switch (unitType)
            {
                case UnitType.Unit:
                    return "Unidade";
                case UnitType.Package:
                    return "Pacote";
                case UnitType.Box:
                    return "Caixa";
                default:
                    return "Desconhecido";
            };
        }
        public static string IntToString(int unitType)
        {
            switch (unitType)
            {
                case (1):
                    return "Unidade";
                case (2):
                    return "Pacote";
                case (3):
                    return "Caixa";
                default:
                    return "Desconhecido";
            };
        }

        public static List<string> GetAllUnitTypes()
        {
            return new List<string>
            {
                IntToString(1),
                IntToString(2),
                IntToString(3)
            };
        }
    }
}
