using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libplctag;
using libplctag.DataTypes;

namespace TestPLC
{
    internal class TestPLc
    {
        public static Tag<StringPlcMapper, string> strTag;
        public static Tag<DintPlcMapper, int> intTag;
        public static String Gateways = "192.168.0.100";
        public static void initialize_plc()
        {
            strTag = new Tag<StringPlcMapper, string>()
            {
                Name = "TAG1_NAME",
                Gateway = Gateways,
                Path = "1,0",
                Protocol = Protocol.ab_eip,
                PlcType = PlcType.ControlLogix,
                Timeout = TimeSpan.FromSeconds(5)
            };
            intTag = new Tag<DintPlcMapper, int>()
            {
                Name = "TAG2_NAME",
                Gateway = Gateways,
                Path = "1,0",
                Protocol = Protocol.ab_eip,
                PlcType = PlcType.ControlLogix,
                Timeout = TimeSpan.FromSeconds(5)
            };
        }
    }


}
