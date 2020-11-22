using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    class Functions
    {
        public static List<List<string>> SearchDrinks(List<string> request)
        {
            List<string> searchPosDrink = new List<string>(); searchPosDrink.Clear();
            List<string> searchNeuDrink = new List<string>(); searchNeuDrink.Clear();
            List<string> searchNegDrink = new List<string>(); searchNegDrink.Clear();
            List<string> DrinksNotFound = new List<string>(); DrinksNotFound.Clear();
            List<string> searchPosDrinks = new List<string>(); searchPosDrinks.Clear();
            List<string> searchNeuDrinks = new List<string>(); searchNeuDrinks.Clear();
            List<string> searchNegDrinks = new List<string>(); searchNegDrinks.Clear();
            List<string> searchPosDrinkss = new List<string>(); searchPosDrinkss.Clear();
            List<string> searchNeuDrinkss = new List<string>(); searchNeuDrinkss.Clear();
            List<string> searchNegDrinkss = new List<string>(); searchNegDrinkss.Clear();
            List<string> searchPosDrinksNoDoubs = new List<string>(); searchPosDrinksNoDoubs.Clear();
            List<string> searchNeuDrinksNoDoubs = new List<string>(); searchNeuDrinksNoDoubs.Clear();
            List<string> searchNegDrinksNoDoubs = new List<string>(); searchNegDrinksNoDoubs.Clear();
            List<List<string>> searchRes = new List<List<string>>(); searchRes.Clear();
            List<List<string>> listInter = new List<List<string>>(); searchRes.Clear();
            Form1.MixComponents.Clear();
            if (File.Exists(@"DataBank\MixComponents.bin")) { if (Form1.MixComponents.Count() == 0) { Form1.MixComponents = LoadDrinks(); } }
            if (request.Count() == 1)
            {
                searchPosDrinksNoDoubs.Clear(); searchNeuDrinksNoDoubs.Clear(); searchNegDrinksNoDoubs.Clear();
                listInter = InDrinkNames(request[0]);//2D List: {counts,searchPosDrink,searchNeuDrink,searchNegDrink}
                if (Int32.Parse(listInter[0][0]) >= 0) { searchPosDrinkss = listInter[1]; searchNeuDrinkss = listInter[2]; searchNegDrinkss = listInter[3]; }
                else if (Int32.Parse(listInter[0][0]) < 0) { DrinksNotFound.Add(request[0]); }
            }
            else if (request.Count() > 1)
            {
                listInter.Clear(); listInter = InDrinkNames(request[0]);//2D List: {counts,searchPosDrink,searchNeuDrink,searchNegDrink}
                if (Int32.Parse(listInter[0][0]) >= 0) { searchPosDrink = listInter[1]; searchNeuDrink = listInter[2]; searchNegDrink = listInter[3]; }
                for (int i = 0; i < request.Count(); i++)
                {
                    searchPosDrinks.Clear(); searchNeuDrinks.Clear(); searchNegDrinks.Clear();
                    searchPosDrinkss.Clear(); searchNeuDrinkss.Clear(); searchNegDrinkss.Clear();
                    listInter.Clear(); listInter = InDrinkNames(request[i]);//2D List: {counts,searchPosDrink,searchNeuDrink,searchNegDrink}
                    if (Int32.Parse(listInter[0][0]) >= 0) { searchPosDrinks = listInter[1]; searchNeuDrinks = listInter[2]; searchNegDrinks = listInter[3]; }
                    else if (Int32.Parse(listInter[0][0]) < 0) { DrinksNotFound.Add(request[i]); }
                    foreach (string element in searchPosDrinks) { if (searchPosDrink.Contains(element)) { searchPosDrinkss.Add(element); } }
                    foreach (string element in searchNeuDrinks) { if (searchNeuDrink.Contains(element)) { searchNeuDrinkss.Add(element); } }
                    foreach (string element in searchNegDrinks) { if (searchNegDrink.Contains(element)) { searchNegDrinkss.Add(element); } }
                    searchPosDrink.Clear(); searchPosDrink = new List<string>(searchPosDrinkss);
                    searchNeuDrink.Clear(); searchNeuDrink = new List<string>(searchNeuDrinkss);
                    searchNegDrink.Clear(); searchNegDrink = new List<string>(searchNegDrinkss);
                }
            }
            //foreach (string element in request){searchPosDrinkss.Add(element);}
            searchPosDrinksNoDoubs = searchPosDrinkss.Distinct().ToList(); searchPosDrinksNoDoubs.Sort();
            searchNeuDrinksNoDoubs = searchNeuDrinkss.Distinct().ToList(); searchNeuDrinksNoDoubs.Sort();
            searchNegDrinksNoDoubs = searchNegDrinkss.Distinct().ToList(); searchNegDrinksNoDoubs.Sort();
            searchRes.Add(searchPosDrinksNoDoubs); searchRes.Add(searchNeuDrinksNoDoubs); searchRes.Add(searchNegDrinksNoDoubs); searchRes.Add(DrinksNotFound);
            return searchRes;
        }
        private static List<List<string>> InDrinkNames(string drinkname)
        {
            List<string> l1 = new List<string>(); l1.Clear();
            List<string> l2 = new List<string>(); l1.Clear();
            List<string> l3 = new List<string>(); l1.Clear();
            List<string> lcountStList = new List<string>(); l1.Clear();
            List<List<string>> resList = new List<List<string>>(); resList.Clear();
            int count1 = -1; 
            for (int j = 0; j < Form1.MixComponents.Count(); j++) { for (int k = 0; k < Form1.MixComponents[j].Count(); k++) { if (Form1.MixComponents[j][k] == drinkname) { count1 += 1; } } }
            if (count1 >= 0)
            {
                foreach (string component in Form1.Compatibility[drinkname + "Pos"]) { if (!l1.Contains(component)) { l1.Add(component); } }
                foreach (string component in Form1.Compatibility[drinkname + "Neu"]) { if (!l2.Contains(component)) { l2.Add(component); } }
                foreach (string component in Form1.Compatibility[drinkname + "Neg"]) { if (!l3.Contains(component)) { l3.Add(component); } }
                //l1.Add(drinkname);
            }
            foreach (string key in Form1.Compatibility.Keys)
            {
                if (Form1.Compatibility[key].Contains(drinkname))
                {
                    string s = key.Substring(key.Length - 3);
                    if (s == "Pos" && !l1.Contains(key.Remove(key.Length - 3))){l1.Add(key.Remove(key.Length - 3));}
                    else if (s == "Neu" && !l2.Contains(key.Remove(key.Length - 3))){l2.Add(key.Remove(key.Length - 3));} 
                    else if (s == "Neg" && !l3.Contains(key.Remove(key.Length - 3))){ l3.Add(key.Remove(key.Length - 3));} 
                }
            }
            string countSt = count1.ToString(); lcountStList.Add(countSt);
            resList.Add(lcountStList); resList.Add(l1); resList.Add(l2); resList.Add(l3);
            return resList;
        }
        public static void SaveList(List<List<string>> lst)
        {
            if (!Directory.Exists(@"DataBank")) { Directory.CreateDirectory(@"DataBank"); }
            string pfad = @"DataBank\MixComponents.bin";
            var binaryFormatter = new BinaryFormatter(); var fi = new FileInfo(pfad);
            using (var binaryFile = fi.Create())
            { binaryFormatter.Serialize(binaryFile, lst); binaryFile.Flush(); }
        }
        public static void SaveDic(Dictionary<string, List<string>> dic)
        {
            if (!Directory.Exists(@"DataBank")) { Directory.CreateDirectory(@"DataBank"); }
            string pfad = @"DataBank\Compatibility.bin";
            var binaryFormatter = new BinaryFormatter(); var fi = new FileInfo(pfad);
            using (var binaryFile = fi.Create())
            { binaryFormatter.Serialize(binaryFile, dic); binaryFile.Flush(); }
        }
        public static void SaveDic1(Dictionary<string, List<string>> dic, string name)
        {
            if (!Directory.Exists(@"DataBank")) { Directory.CreateDirectory(@"DataBank"); }
            string pfad = @"DataBank\" + name + ".bin";
            var binaryFormatter = new BinaryFormatter(); var fi = new FileInfo(pfad);
            using (var binaryFile = fi.Create())
            { binaryFormatter.Serialize(binaryFile, dic); binaryFile.Flush(); }
        }
        public static List<List<string>> LoadDrinks()
        {
            List<List<string>> DrinkList = new List<List<string>>(); DrinkList.Clear();
            if (File.Exists(@"DataBank\MixComponents.bin"))
            {
                FileStream fs = new FileStream(@"DataBank\MixComponents.bin", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                DrinkList = (List<List<string>>)formatter.Deserialize(fs);
                fs.Close();
            }
            foreach (List<string> el in DrinkList) { el.Sort(); }
            return DrinkList;
        }
        public static List<string> LoadDrinks1D(string name)
        {
            List<string> DrinkList = new List<string>(); DrinkList.Clear();
            if (File.Exists(@"DataBank\" + name + ".bin"))
            {
                FileStream fs = new FileStream(@"DataBank\" + name + ".bin", FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                DrinkList = (List<string>)formatter.Deserialize(fs);
                fs.Close();
            }
            DrinkList.Sort();
            return DrinkList;
        }
        public static Dictionary<string, List<string>> LoadDB()
        {
            Dictionary<string, List<string>> MixDB = new Dictionary<string, List<string>>();
            FileStream fs = new FileStream(@"DataBank\Compatibility.bin", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            MixDB = (Dictionary<string, List<string>>)formatter.Deserialize(fs);
            fs.Close();
            return MixDB;
        }
        public static Dictionary<string, List<string>> LoadDB1(string name)
        {
            Dictionary<string, List<string>> MixDB = new Dictionary<string, List<string>>();
            FileStream fs = new FileStream(@"DataBank\" + name + ".bin", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            MixDB = (Dictionary<string, List<string>>)formatter.Deserialize(fs);
            fs.Close();
            return MixDB;
        }
        public static List<string> Splitting(string name, char a)
        {
            List<string> splitList = new List<string>(); splitList.Clear();string[] splitted = name.Split(a);
            foreach (string spl in splitted){if (spl != "" && spl != " " && spl != null){ splitList.Add(spl); }}
            return splitList;
        }
        public static List<List<string>> Sort2DList(List<List<string>> name)
        {
            int index = 0; int b = name.Count(); List<List<string>> name1 = new List<List<string>>();
            for (int j = 0; j < b; j++)
            {
                for (int i = 0; i < name.Count(); i++)
                {
                    List<string> inter = new List<string>(); inter.Clear();
                    char a = name[0][0].ToCharArray()[0];
                    if (name[i][0].ToCharArray()[0] <= a)
                    { a = name[i][0].ToCharArray()[0]; index = i; }
                }
                name1.Add(name[index]); name.RemoveAt(index);
            }
            return name1;
        }
        public static List<string> NameToUpper(List<string> name)
        {
            List<string> name1 = new List<string>(); string nam1 = string.Empty;
            foreach (string nam in name)
            {
                if (!String.IsNullOrEmpty(nam))
                { nam1 = nam.Substring(0, 1).ToUpper() + nam.Substring(1); }
                else { nam1 = nam; }
                name1.Add(nam1);
            }
            return name1;
        }
        public static string StringToUpper(string name) 
        { 
            return name.Substring(0, 1).ToUpper() + name.Substring(1); 
        }
        public static List<List<string>> ListEqualizer(List<List<string>> listEq)
        {
            List<List<string>> lst2D = new List<List<string>>(); lst2D.Clear();
            int indMax = 0; List<string> indMaxList = new List<string>(); indMaxList.Clear();
            List<int> counts = new List<int>(); counts.Clear();
            for (int i = 0; i < listEq.Count(); i++) { if (listEq[i].Count() > indMax) { indMax = listEq[i].Count(); } }
            indMaxList.Add(indMax.ToString()); lst2D.Add(indMaxList);
            for (int i = 0; i < listEq.Count(); i++){int n = listEq[i].Count();for (int j = 0; j < indMax - n; j++){listEq[i].Add("");}lst2D.Add(listEq[i]);}
            return lst2D;
        }
        public static Dictionary<string, List<string>> SortDic(Dictionary<string, List<string>> dic)
        {
            List<string> values = new List<string>(); values.Clear(); Dictionary<string, List<string>> dic1 = new Dictionary<string, List<string>>();
            dic = dic.Keys.OrderBy(k => k).ToDictionary(k => k, k => dic[k]);
            dic1 = new Dictionary<string, List<string>>(dic);
            foreach (string key in dic.Keys) { values.Clear(); values = dic1[key]; values.Sort(); dic1[key] = new List<string>(values); }
            return dic1;
        }
    }
}
