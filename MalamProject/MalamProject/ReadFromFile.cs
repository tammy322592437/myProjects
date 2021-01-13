using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MalamProject
{
    public class ReadFromFile
    {

        public void ReadFromFileFunc(string textFile)
        {
            try
            {
                int maxDict;
                //for the purpose of saving the data has been assigned dictonary  the key is the first four organs and the value is a list of strings because of the phone that some people have with some phones
                Dictionary<string, List<List<string>>> data = new Dictionary<string, List<List<string>>>();
                string[] lines = System.IO.File.ReadAllLines(textFile);
                data = addName(lines[0], 0, data);
                maxDict = data.Count;//saves to print only to those with a first name
                data = addName(lines[1], 1, data);
                data = addPhone(lines[2], 2, data);
                data = addDate(lines[3], 3, data);
                print(data, 3, maxDict);
            }
            catch (IOException e)
            {
                Console.WriteLine("the message is: " + e.Message);
            }
        }

        private Dictionary<string, List<List<string>>> addDate(string text, int index, Dictionary<string, List<List<string>>> data)
        {
            int i, countInt = 0, j;
            string key, dateString = "";
            bool flag = false;
            for (i = 4; i < text.Count();)
            {
                dateString = "";
                key = getKey(text, ref i);//get the key of the value
                countInt = getCount(text, index, ref i, ref flag);//get the amount of organs on date it is always is 10 
                for (j = 0; j < countInt; dateString += text[i++], j++) ;//fill amount of seconds that need to be added from 1/1/1970
                DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                dt = dt.AddSeconds(Convert.ToInt32(dateString));
                data = addDictonary(data, dt.ToString(), index, key);//stores data  as a string
            }
            return data;
        }
        private Dictionary<string, List<List<string>>> addPhone(string text, int index, Dictionary<string, List<List<string>>> data)
        {
            int i, countInt = 0;
            string key, phone = "";
            bool flag = false;

            for (i = 4; i < text.Count();)
            {
                key = getKey(text, ref i);//get the key of the value 
                countInt = getCount(text, index, ref i, ref flag);//get the amount of organs and what kind of data entry
                if (flag)
                    phone = getPhoneByNumbers(text, countInt, ref i);//when return true from the function - the amount  be inserted to phone is just numbers and not chars
                else
                    phone = getPhoneByChars(text, countInt, ref i);//when return false from the function - the amount  be inserted to phone is including chars
                data = addDictonary(data, phone, index, key);//save the data
            }
            return data;
        }

        private string getPhoneByChars(string text, int countInt, ref int i)
        {
            string phone = "";
            for (int j = 0; j < countInt; j++, i++)
                phone += text[i];
            return phone;
        }

        private string getPhoneByNumbers(string text, int countInt, ref int i)
        {
            string phone = "";
            for (int j = 0; j < countInt; i++)
            {
                if (text[i] >= '0' && text[i] <= '9')
                {
                    j++;
                }
                phone += text[i];
            }
            return phone;
        }

        private string getKey(string text, ref int i)
        {
            int j;
            string key = "";

            for (j = 0; j < 4; j++, i++)
            {
                key += text[i];
            }

            return key;
        }
        private void print(Dictionary<string, List<List<string>>> data, int index, int max)
        {
            int i, p = 0;
            foreach (var item in data)
            {
                if (++p > max)
                    return;
                if (item.Value.Count == index + 1)//print only if there is all the data
                {
                    for (i = 0; i <= index; i++)
                        for (int j = 0; j < item.Value[i].Count(); j++)
                            Console.Write(item.Value[i][j] + " ");
                    Console.WriteLine();
                }
            }
        }

        private Dictionary<string, List<List<string>>> addName(string text, int index, Dictionary<string, List<List<string>>> data)
        {

            string key = "", name = "";
            int countInt = 0, j, i;
            bool flag = false;

            for (i = 4; i < text.Count();)
            {
                key = getKey(text, ref i);//get the key of the value 
                countInt = getCount(text, index, ref i, ref flag);//get the amount of organs
                for (j = 0; j < countInt; j++, i++)//fill the name and when there is a space insert " " and not a lower from number of organs
                {
                    if (text[i] == 65533)
                    {
                        name += ' ';
                        i++;
                    }
                    name += text[i];

                }
                data = addDictonary(data, name, index, key);//save the data
                key = "";
                name = "";

            }

            return data;
        }

        private Dictionary<string, List<List<string>>> addDictonary(Dictionary<string, List<List<string>>> data, string value, int index, string key)
        {
            if (!data.ContainsKey(key))//when this key is still not found
            {

                List<List<string>> list = new List<List<string>>();
                List<string> l = new List<string>();
                for (int i = 0; i < index; i++)//if there are values ​​that do not appear in this key,will be added to the list ""
                {
                    l.Add("");
                    list.Add(l);
                }
                l.Add(value);
                list.Add(l);
                data.Add(key, list);
            }
            else
            {
                List<List<string>> list = data[key];

                if (list.Count <= index)//when the key is found but the current parameter is the first one, a new list will be assigned and the value will be entered
                {

                    List<string> l = new List<string>();
                    l.Add(value);
                    list.Add(l);
                }
                else
                {
                    List<string> l = list[index];//when this is not the first  parameter example in the phone the value will be added to the parameter list

                    l.Add(value);

                }
            }
            return data;
        }

        private int getCount(string text, int index, ref int i, ref bool flag1)
        {
            int j, countInt;
            string countString = "";
            bool flag = true;
            for (j = 0; j < 5; j++, i++)
            {
                if (flag && text[i] == '0')
                    continue;
                flag = false;
                countString += text[i];
            }
            if (countString.Length == 2)
                flag1 = true;
            else flag1 = false;
            switch (countString)//  convert from askii to int 

            {
                case "A":
                    countInt = 10;
                    break;
                case "B":
                    countInt = 11;
                    break;
                case "C":
                    countInt = 12;
                    break;
                case "D":
                    countInt = 13;
                    break;
                case "E":
                    countInt = 14;
                    break;
                case "F":
                    countInt = 15;
                    break;
                default:
                    countInt = Convert.ToInt32(countString);
                    if (index <= 1 && countInt >= 10)//in first name or last name when the amount bigger than 10 add 4
                        countInt += 4;
                    break;

            }
            return countInt;
        }
    }
}
