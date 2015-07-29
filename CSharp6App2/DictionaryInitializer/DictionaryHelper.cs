using System;
using System.Collections.Generic;
using static System.ConsoleColor;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace CSharp6App2.DictionaryInitializer
{
    internal class DictionaryHelper
    {
        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion

        public DictionaryHelper()
        {
        }

        #region Ex1 - old init
        public void Ex1_Old()
        {
            var dic = new Dictionary<string, ConsoleColor>()
            {
                {"Red", Red },
                {"Yellow", Yellow },
                {"Blue", Blue }
            };
        }
        #endregion

        #region Ex1 - new init
        public void Ex1_New()
        {
            var dic = new Dictionary<string, ConsoleColor>()
            {
                ["Red"] = Red,
                ["Yellow"] = Yellow,
                ["Blue"] = Blue
            };
        }
        #endregion

        #region ex2 - dic - JSON Methods Helpers

        public JObject ToJson() => new JObject() {["x"] = X,["y"] = Y };

        #endregion

        #region ex3 - int index
        public Dictionary<int, string> Ex3()
        {
            var aDic = new Dictionary<int, string>
            {
                [10] = "10",
                [20] = "20",
                [30] = "30"
            };

            return aDic;
        }
        #endregion

        #region ex4 - List<int>
        public List<int> Ex4()
        {

            var list = new List<int>
            {
                [0] = 10,
                [4] = 2,
                [10] = 231
            };

            #region correct
            //  var list = new List<int>(Enumerable.Repeat(0,11))
            #endregion

            return list;
        }
        #endregion
    }
}