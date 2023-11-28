using System.Reflection;

//Type t = typeof(string);
//MethodInfo[] methodInfos = t.GetMethods();

////foreach (MethodInfo methodInfo in methodInfos)
////    Console.WriteLine(methodInfo);

//FieldInfo[] fieldInfos = t.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
//foreach (FieldInfo fieldInfo in fieldInfos)
//{
//    if (fieldInfo.Name == "_firstChar") {
//        string hello = "Hello";
//        fieldInfo.SetValue(hello, 'h');
//        char c = (char)fieldInfo.GetValue(hello);
//        Console.WriteLine(c);
//    }
//        Console.WriteLine(fieldInfo);
//}


Assembly assembly = Assembly.LoadFrom("Spa.dll");
Module module = assembly.GetModule("Spa.dll");

foreach (Type type in module.GetTypes())
{
    Console.WriteLine(type);
}
