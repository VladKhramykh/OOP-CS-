using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_12
{
    static class Reflector
    {
        static Type type;
        static public void WriteInfoInFile(string ClassName, string path)
        {
            try
            {
                type = Type.GetType(ClassName, false, true);

                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Тип: " + type.ToString());
                    sw.WriteLine("Методы:");
                    foreach (var method in type.GetMethods())
                    {
                        string result = "";
                        if (method.IsStatic)
                            result += "static ";
                        if (method.IsVirtual)
                            result += "virtual ";
                        sw.Write("\t" + result + method.ReturnType.Name + " " + method.Name + "(");
                        ParameterInfo[] parameters = method.GetParameters();
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            sw.Write(parameters[i].ParameterType.Name + " " + parameters[i].Name);
                            if (i + 1 < parameters.Length)
                                sw.Write(", ");
                        }
                        sw.WriteLine(")");
                    }

                    sw.WriteLine("Поля:");
                    foreach (var prop in type.GetProperties())
                        sw.WriteLine($"\t{prop.Name}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static public void ShowPublicMethods(string ClassName)
        {
            type = Type.GetType(ClassName, false, true);
            Console.WriteLine("\npublic-методы:");
            foreach(var method in type.GetMethods())
            {
                string result = "";
                if (method.IsPublic)
                {
                    result += "public ";
                    result += method.ReturnType.Name;
                    result += " " + method.Name+" (";
                    ParameterInfo[] parameters = method.GetParameters();
                    for (int i =0; i<parameters.Length; i++)
                    {
                        result += parameters[i].ParameterType.Name + " " + parameters[i].Name;
                        if (i + 1 < parameters.Length)
                            result += ",";
                    }
                    result += ")";
                    Console.WriteLine(result);
                }
                    
            }
        }

        static public void MethodsAndFieldsInfo(string ClassName)
        {
            type = Type.GetType(ClassName, false, true);

            Console.WriteLine("\nПоля:");
            foreach (FieldInfo field in type.GetFields())
            {
                Console.WriteLine("{0} {1}", field.FieldType, field.Name);
            }

            Console.WriteLine("Свойства:");
            foreach (PropertyInfo prop in type.GetProperties())
            {
                Console.WriteLine("{0} {1}", prop.PropertyType, prop.Name);
            }
        }

        static public void ShowInterfaces(string ClassName)
        {
            type = Type.GetType(ClassName, false, true);
            Console.WriteLine($"\nРеализованные к классе {ClassName} интерфейсы");
            foreach (Type i in type.GetInterfaces())
                Console.WriteLine(i.Name);
        }

        static public void UsersTypeParmInMethods(string ClassName, string TypeParm)
        {
            Console.WriteLine($"\nПараметр с типом {TypeParm} есть в методах: ");
            type = Type.GetType(ClassName, false, true);
            ParameterInfo[] parameters;
            foreach (var method in type.GetMethods())
            {
                parameters = method.GetParameters();
                                   
                for (int i = 0; i < parameters.Length; i++)
                {

                    if (Equals(parameters[i].ParameterType.Name, TypeParm))
                    {
                        string result = "";
                        if (method.IsPublic)                        
                            result += "public ";

                        result += method.ReturnType.Name;
                        result += " " + method.Name + " (";
                        for (int j = 0; j < parameters.Length; j++)
                        {
                            result += parameters[j].ParameterType.Name + " " + parameters[j].Name;
                            if (j + 1 < parameters.Length)
                                result += ", ";
                        }
                        result += ")";
                        Console.WriteLine(result);
                        break;
                    }                                   
                }
               
            
            }
        }


        static public void CallFromFile(Player obj, string MethodsName)
        {
            FileStream file = new FileStream("call.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file);
            object[] Arr = { reader.ReadLine() };
            type = typeof(Player);
            MethodInfo metod = type.GetMethod(MethodsName);
            object mval = metod.Invoke(obj, Arr);
            Console.WriteLine(mval);
        }
    }
}
