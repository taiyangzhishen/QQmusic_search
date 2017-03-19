using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 音乐搜索
{
    public class music
    {

        public class Rootobject
        {
            public int code { get; set; }
            public Data data { get; set; }
            public string message { get; set; }
            public string notice { get; set; }
            public int subcode { get; set; }
            public int time { get; set; }
            public string tips { get; set; }
        }

        public class Data
        {
            public string keyword { get; set; }
            public int priority { get; set; }
            public object[] qc { get; set; }
            public Semantic semantic { get; set; }
            public Song song { get; set; }
            public int totaltime { get; set; }
            public Zhida zhida { get; set; }
        }

        public class Semantic
        {
            public int curnum { get; set; }
            public int curpage { get; set; }
            public object[] list { get; set; }
            public int totalnum { get; set; }
        }

        public class Song
        {
            public int curnum { get; set; }
            public int curpage { get; set; }
            public List[] list { get; set; }
            public int totalnum { get; set; }
        }

        public class List
        {
            public int albumid { get; set; }
            public string albummid { get; set; }
            public string albumname { get; set; }
            public string albumname_hilight { get; set; }
            public int alertid { get; set; }
            public int chinesesinger { get; set; }
            public string docid { get; set; }
            public object[] grp { get; set; }
            public int interval { get; set; }
            public int isonly { get; set; }
            public string lyric { get; set; }
            public string lyric_hilight { get; set; }
            public int msgid { get; set; }
            public long nt { get; set; }
            public Pay pay { get; set; }
            public Preview preview { get; set; }
            public int pubtime { get; set; }
            public int pure { get; set; }
            public Singer[] singer { get; set; }
            public int size128 { get; set; }
            public int size320 { get; set; }
            public int sizeape { get; set; }
            public int sizeflac { get; set; }
            public int sizeogg { get; set; }
            public int songid { get; set; }
            public string songmid { get; set; }
            public string songname { get; set; }
            public string songname_hilight { get; set; }
            public int stream { get; set; }
            public int _switch { get; set; }
            public int t { get; set; }
            public int tag { get; set; }
            public int type { get; set; }
            public int ver { get; set; }
            public string vid { get; set; }
            public string format { get; set; }
            public string songurl { get; set; }
        }

        public class Pay
        {
            public int payalbum { get; set; }
            public int payalbumprice { get; set; }
            public int paydownload { get; set; }
            public int payinfo { get; set; }
            public int payplay { get; set; }
            public int paytrackmouth { get; set; }
            public int paytrackprice { get; set; }
        }

        public class Preview
        {
            public int trybegin { get; set; }
            public int tryend { get; set; }
            public int trysize { get; set; }
        }

        public class Singer
        {
            public int id { get; set; }
            public string mid { get; set; }
            public string name { get; set; }
            public string name_hilight { get; set; }
        }

        public class Zhida
        {
            public int chinesesinger { get; set; }
            public int type { get; set; }
        }

    }
}
