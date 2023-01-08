using System.Reflection;
string path = @"/home/monster/dotNet/lab/computerShop/Catlog/bin/Debug/net7.0/Catlog.dll";
//path to class file you want meta data from {reflection}

Assembly asm =Assembly.LoadFile(path);
string name = asm.FullName;
Console.WriteLine(name);

Type[] types = asm.GetTypes();
for(int i=0;i<types.Count();i++){
    string typeName = types[i].Name;
    Console.WriteLine(typeName);
    MethodInfo [] mi = types [i].GetMethods();

    foreach(MethodInfo m in mi){
        string methodName = m.Name;
        Console.WriteLine(methodName);
    }
}