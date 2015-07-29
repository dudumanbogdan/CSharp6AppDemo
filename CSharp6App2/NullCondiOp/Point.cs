using Newtonsoft.Json.Linq;

namespace CSharp6App2.NullCondiOp
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        #region ex3 - old - Null conditional operators
        public static Point FromJson(JObject json)
        {
            if (json != null &&
                json["x"] != null && json["x"].Type == JTokenType.Integer &&
                json["y"] != null && json["y"].Type == JTokenType.Integer)
            {
                return new Point { X = (int)json["x"], Y = (int)json["y"] };
            }

            return null;
        }
        #endregion

        #region ex3 - new - Null conditional operators
        public static Point FromJson2(JObject json)
        {
            if (json?["x"]?.Type == JTokenType.Integer && json["y"]?.Type == JTokenType.Integer)
            {
                return new Point { X = (int)json["x"], Y = (int)json["y"] };
            }

            return null;
        }
        #endregion

        public override string ToString()
        {
            return $"Point X:{X} , Y:{Y}";
        }
    }
}
