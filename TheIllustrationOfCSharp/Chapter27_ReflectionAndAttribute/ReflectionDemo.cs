/**
 * 参考文档：https://www.cnblogs.com/daxiaxiaohao/p/4135740.html 
 */
using System;
using System.Reflection;

namespace Chapter27_ReflectionAndAttribute
{
    class ReflectionDemo
    {
        public static void Example1()
        {
            //使用Assembly定义和加载程序集，加载在程序集清单中列出模块，以及从此程序集中查找类型并创建该类型的实例。 
            Assembly assembly = Assembly.Load("Chapter27_ReflectionAndAttribute");

            Module[] _modules = assembly.GetModules();
            foreach (Module module in _modules)
            {
                Console.WriteLine("Assembly module name = " + module.Name);               
            }

            //得到程序集中所有的名称
            //foreach (Type type in assembly.GetTypes())
            //{
            //    Console.WriteLine("assembly name = " + type.ToString());
            //}

            // 获取当前类的实例
            Type _type = assembly.GetType("Chapter27_ReflectionAndAttribute.ReflectionDemo");

            Console.WriteLine("通过 typeof 获取 Type = " + typeof(ReflectionDemo).ToString());
            

            // 获取此类实例
            ReflectionDemo _demo = Activator.CreateInstance(_type) as ReflectionDemo;

            //获取当前方法
            MethodInfo mInfo = _type.GetMethod("Show");            
            //调用
            mInfo.Invoke(null, null);

            Module _module = _type.Module;
            Console.WriteLine("module = " + _module.ToString());
        }

        public static void Show()
        {
            Console.WriteLine(TheCurrentClassName());
        }

        public static string TheCurrentClassName()
        {
            return "ReflectionDemo";
        }
    }
}
